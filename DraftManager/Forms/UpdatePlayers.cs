using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DraftManager.Models;

namespace DraftManager.Forms
{
    public partial class UpdatePlayers : Form
    {
        private readonly DraftContext context = new DraftContext();
        private List<Player> players = new List<Player>();
        private bool Loaded = false;

        public UpdatePlayers()
        {
            InitializeComponent();
            groupBoxDetails.Visible = false;
            numericUpDownRank.Minimum = 0;
            numericUpDownRank.Maximum = context.Players.Count();
            BindPlayers();
            Loaded = false;
            comboBoxPosition.DataSource = new List<string>
            {
                "RB", "WR", "TE", "QB", "K", "D/ST"
            };
            comboBoxTeam.DataSource = context.Teams.OrderBy(t => t.Abbreviation).ToList();
            comboBoxTeam.DisplayMember = "Abbreviation";
            Loaded = true;
        }

        private void BindPlayers()
        {
            players = context.Players.ToList();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxPlayers.DataSource = players.OrderBy(p => p.Rank).ToList();
            listBoxPlayers.DisplayMember = "Name";
        }

        private void textBoxFilter_TextChanged(object sender, System.EventArgs e)
        {
            listBoxPlayers.DataSource = players.Where(p => p.Name.ToUpper().Contains(textBoxFilter.Text.ToUpper())).ToList();
            groupBoxDetails.Visible = listBoxPlayers.Items.Count > 0;
        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Loaded = false;
            var player = (Player)listBoxPlayers.SelectedItem;
            groupBoxDetails.Visible = player != null;
            numericUpDownRank.Value = player?.Rank ?? 0;
            textBoxFirstName.Text = player?.FirstName;
            textBoxLastName.Text = player?.LastName;
            comboBoxPosition.SelectedItem = player?.Position;
            comboBoxTeam.SelectedItem = player?.Team;
            checkBoxInjured.Checked = player?.Injured ?? false;

            groupBoxDetails.Visible = true;
            Loaded = player != null;
        }

        private void UpdatePlayer()
        {
            var player = (Player) listBoxPlayers.SelectedItem;
            if (player == null) return;
            player.FirstName = textBoxFirstName.Text;
            player.LastName = textBoxLastName.Text;
            player.Position = (string) comboBoxPosition.SelectedItem;

            var diff = numericUpDownRank.Value - player.Rank;
            if (diff > 0)
            {
                var shifters = players.Where(p => p.Rank > player.Rank && p.Rank <= numericUpDownRank.Value).ToList();
                shifters.ForEach(p => p.LowerRank());
            }
            else if (numericUpDownRank.Value < player.Rank)
            {
                var shifters = players.Where(p => p.Rank < player.Rank && p.Rank >= numericUpDownRank.Value).ToList();
                shifters.ForEach(p => p.RaiseRank());
            }
            player.Rank = (int)numericUpDownRank.Value;
            player.TeamId = ((Team)comboBoxTeam.SelectedItem).Id;
            player.Injured = checkBoxInjured.Checked;

            context.SaveChanges();
            UpdateListBox();
            listBoxPlayers.SelectedItem = player;
        }

        private void generic_ValueChanged(object sender, System.EventArgs e)
        {
            if(Loaded) UpdatePlayer();
        }
    }
}