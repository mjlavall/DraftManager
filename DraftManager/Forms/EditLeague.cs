using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DraftManager.Models;

namespace DraftManager.Forms
{
    public partial class EditLeague : Form
    {
        private DraftContext context = new DraftContext();
        private List<Roster> Rosters = new List<Roster>();
        private League _league;

        public EditLeague()
        {
            InitializeComponent();
            _league = context.Leagues.First();
            comboBoxLeague.DataSource = context.Leagues.OrderBy(l => l.Name).ToList();
            comboBoxLeague.DisplayMember = "Name";
            UpdateListBox();
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            var teamName = string.IsNullOrEmpty(textBoxTeam.Text) ? $"Team {(_league.Rosters?.Count ?? 0) + 1}" : textBoxTeam.Text;
            var roster = new Roster(_league.Id)
            {
                Name = teamName,
                DraftOrder = (_league.Rosters?.Count ?? 0) + 1
            };
            context.Rosters.Add(roster);
            context.SaveChanges();
            UpdateListBox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var roster = (Roster)listBoxTeams.SelectedItem;
            if (roster == null) return;
            context.Rosters.Remove(roster);
            context.SaveChanges();
            for (int i = 0; i < _league.Rosters.Count(); i++)
            {
                _league.Rosters.ToList()[i].DraftOrder = i + 1;
            }
            context.SaveChanges();
            UpdateListBox();
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
            if (newIndex < 0 || newIndex >= _league.Rosters.Count) return;
            var roster = (Roster)listBoxTeams.SelectedItem;
            if (roster == null) return;
            ((Roster)listBoxTeams.Items[currentIndex + direction]).DraftOrder = roster.DraftOrder;
            roster.DraftOrder += direction;

            context.SaveChanges();
            UpdateListBox();
            listBoxTeams.SelectedItem = roster;
        }

        private void UpdateListBox()
        {
            listBoxTeams.DataSource = _league.Rosters?.OrderBy(r => r.DraftOrder).ToList() ?? new List<Roster>();
            listBoxTeams.DisplayMember = "Name";
        }

        private void comboBoxLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            _league = (League)comboBoxLeague.SelectedItem;
            UpdateListBox();
        }
    }
}
