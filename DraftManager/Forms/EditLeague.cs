using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DraftManager.Models;

namespace DraftManager.Forms
{
    public partial class EditLeague : Form
    {
        private readonly DraftDay _draft;
        private League League => comboBoxLeague.SelectedItem as League;

        public EditLeague(DraftDay draft)
        {
            InitializeComponent();
            _draft = draft;
            comboBoxLeague.DataSource = _draft?.Context.Leagues.OrderBy(l => l.Name).ToList();
            UpdateListBox();
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            var teamName = string.IsNullOrEmpty(textBoxTeam.Text) ? $"Team {(League.Rosters?.Count ?? 0) + 1}" : textBoxTeam.Text;
            textBoxTeam.Text = "";
            var roster = new Roster(League.Id)
            {
                Name = teamName,
                DraftOrder = (League.Rosters?.Count ?? 0) + 1,
                LeagueId = League.Id
            };
            League?.Rosters?.Add(roster);
            _draft?.Context.Rosters.Add(roster);
            _draft?.Context.SaveChanges();
            UpdateListBox();
            _draft?.InitializeDraft(false);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var roster = (Roster)listBoxTeams.SelectedItem;
            if (roster == null) return;
            _draft?.Context.Rosters.Remove(roster);
            _draft?.Context.SaveChanges();
            for (var i = 0; i < League.Rosters.Count; i++)
            {
                League.Rosters.ToList()[i].DraftOrder = i + 1;
            }
            _draft?.Context.SaveChanges();
            UpdateListBox();
            _draft?.InitializeDraft(false);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            UpdateOrder(listBoxTeams.SelectedIndex, -1);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            UpdateOrder(listBoxTeams.SelectedIndex, 1);
        }

        private void UpdateOrder(int currentIndex, int direction)
        {
            var newIndex = currentIndex + direction;
            if (newIndex < 0 || newIndex >= League.Rosters.Count) return;
            var roster = (Roster)listBoxTeams.SelectedItem;
            if (roster == null) return;
            ((Roster)listBoxTeams.Items[currentIndex + direction]).DraftOrder = roster.DraftOrder;
            roster.DraftOrder += direction;

            _draft?.Context.SaveChanges();
            UpdateListBox();
            listBoxTeams.SelectedItem = roster;
            _draft?.InitializeDraft(false);
        }

        private void UpdateListBox()
        {
            listBoxTeams.DataSource = League.Rosters?.OrderBy(r => r.DraftOrder).ToList() ?? new List<Roster>();
        }

        private void comboBoxLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void buttonClearRosters_Click(object sender, EventArgs e)
        {
            foreach (var roster in League.Rosters)
            {
                roster.Players.Clear();
            }
            _draft?.Context.SaveChanges();
            _draft?.InitializeDraft(false);
        }

        private void listBoxTeams_DoubleClick(object sender, EventArgs e)
        {
            var roster = (Roster)listBoxTeams.SelectedItem;
            League.Rosters.ToList().ForEach(r => r.IsMe = false);
            roster.IsMe = true;
            _draft?.Context.SaveChanges();
            UpdateListBox();
            _draft?.InitializeDraft(false);
        }

        private void buttonDeleteLeague_Click(object sender, EventArgs e)
        {
            if (League != null) _draft?.Context.Leagues.Remove(League);
            _draft?.Context.SaveChanges();
            comboBoxLeague.DataSource = _draft?.Context.Leagues.OrderBy(l => l.Name).ToList();
            UpdateListBox();
            _draft?.InitializeDraft(true);
        }
    }
}
