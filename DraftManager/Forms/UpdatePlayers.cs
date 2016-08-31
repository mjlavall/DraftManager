using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DraftManager.Models;

namespace DraftManager.Forms
{
    public partial class UpdatePlayers : Form
    {
        private readonly DraftDay _draft;
        private bool _loaded;

        public UpdatePlayers(DraftDay draft)
        {
            InitializeComponent();
            _draft = draft;
            groupBoxDetails.Visible = false;
            numericUpDownRank.Minimum = 0;
            numericUpDownRank.Maximum = _draft?.Context.Players.Count() ?? 0;
            UpdateListBox();
            _loaded = false;
            comboBoxPosition.DataSource = new List<string>
            {
                "RB", "WR", "TE", "QB", "K", "D/ST"
            };
            comboBoxTeam.DataSource = _draft?.Context.Teams.OrderBy(t => t.Abbreviation).ToList();
            comboBoxTeam.DisplayMember = "Abbreviation";
            _loaded = true;
        }

        private void UpdateListBox()
        {
            listBoxPlayers.DataSource = _draft?.Context.Players.ToList()
                .Where(p => p.Name.ToUpper().Contains(textBoxFilter.Text.ToUpper()))
                .OrderBy(p => p.Rank)
                .ToList();
            listBoxPlayers.DisplayMember = "Name";
        }

        private void textBoxFilter_TextChanged(object sender, System.EventArgs e)
        {
            UpdateListBox();
            groupBoxDetails.Visible = listBoxPlayers.Items.Count > 0;
        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _loaded = false;
            var player = listBoxPlayers.SelectedItem as Player;
            groupBoxDetails.Visible = player != null;
            numericUpDownRank.Value = player?.Rank ?? 0;
            textBoxFirstName.Text = player?.FirstName;
            textBoxLastName.Text = player?.LastName;
            comboBoxPosition.SelectedItem = player?.Position;
            comboBoxTeam.SelectedItem = player?.Team;
            checkBoxInjured.Checked = player?.Injured ?? false;
            checkBoxOut.Checked = player?.Out ?? false;
            groupBoxDetails.Visible = _loaded = player != null;
        }

        private void UpdatePlayer()
        {
            var player = listBoxPlayers.SelectedItem as Player;
            if (player == null) return;
            player.FirstName = textBoxFirstName.Text;
            player.LastName = textBoxLastName.Text;
            player.Position = (string) comboBoxPosition.SelectedItem;

            var diff = numericUpDownRank.Value - player.Rank;
            if (diff > 0)
            {
                var shifters = _draft?.Context.Players.Where(p => p.Rank > player.Rank && p.Rank <= numericUpDownRank.Value).ToList();
                shifters?.ForEach(p => p.LowerRank());
            }
            else if (numericUpDownRank.Value < player.Rank)
            {
                var shifters = _draft?.Context.Players.Where(p => p.Rank < player.Rank && p.Rank >= numericUpDownRank.Value).ToList();
                shifters?.ForEach(p => p.RaiseRank());
            }
            player.Rank = (int)numericUpDownRank.Value;
            player.TeamId = ((Team)comboBoxTeam.SelectedItem).Id;
            player.Injured = checkBoxInjured.Checked;
            player.Out = checkBoxOut.Checked;

            _draft?.Context.SaveChanges();
            UpdateListBox();
            listBoxPlayers.SelectedItem = player;
            _draft?.InitializeDraft();
        }

        private void generic_ValueChanged(object sender, System.EventArgs e)
        {
            if(_loaded) UpdatePlayer();
        }
    }
}