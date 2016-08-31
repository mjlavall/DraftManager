using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DraftManager.Models;
using DraftManager.Properties;

namespace DraftManager.Forms
{
    public partial class DraftDay : Form
    {
        public readonly DraftContext Context = new DraftContext();
        private League League => comboBoxLeague.SelectedItem as League;
        private int Picks => Selected?.Count ?? 0;
        private int Teams => League?.Rosters?.Count ?? 0;
        private int Direction => (Picks / Teams) % 2 == 0 ? 1 : -1;
        private int Index => Direction > 0 ? Picks % Teams : Teams - Picks % Teams - 1;
        private Roster Roster => League.Rosters?.OrderBy(r => r.DraftOrder).ToList()[Index];
        private List<Player> Selected
        {
            get
            {
                var selected = new List<Player>();
                if(League.Rosters == null) return selected;
                foreach (var roster in League.Rosters)
                {
                    selected.AddRange(roster.Players);
                }
                return selected;
            }
        }

        public DraftDay()
        {
            InitializeComponent();
            InitializeDraft();
        }

        public void InitializeDraft(bool updateLeagues = true)
        {
            if (!Context.Leagues.Any()) return;
            if (updateLeagues)
            {
                var selectedLeague = comboBoxLeague.SelectedItem as League;
                comboBoxLeague.DataSource = Context.Leagues.ToList();
                if(selectedLeague != null) comboBoxLeague.SelectedItem = selectedLeague;
            }
            if (Teams == 0)
            {
                listBoxRoster.DataSource = new List<Player>();
                listBoxMyTeam.DataSource = new List<Player>();
                labelCurrentTeam.Text = "";
                labelRoundInfo.Text = Resources.DraftDay_InitializeDraft_No_Teams_Configured;
                return;
            }
            BindAvailablePlayers();
            comboBoxFilter.DataSource = new List<string> { "ALL", "RB", "WR", "TE", "QB", "K", "D/ST" };
            SetRoundInfo();
            BindRoster();
        }

        private void SetRoundInfo()
        {
            labelRoundInfo.Text = $"Round {(Picks / Teams) + 1} - {Roster?.Name}";
            labelCurrentTeam.Text = Roster?.Name;
        }
    
        private void BindAvailablePlayers()
        {
            var available = Context.Players.ToList().Where(p => Selected.All(s => s.Id != p.Id)).ToList();
            var filterName = textBoxFilter.Text.ToUpper();
            var posFilter = (string) comboBoxFilter.SelectedItem;
            listBoxAvailablePlayers.DataSource = available.Where(p => p.Name.ToUpper().Contains(filterName) && (posFilter == "ALL" || posFilter == p.Position))
                .OrderBy(p => p.Rank).ToList();
        }

        private void BindRoster()
        {
            listBoxRoster.DataSource = Roster.Players.ToList();
            listBoxMyTeam.DataSource = League.Rosters.SingleOrDefault(r => r.IsMe)?.Players.OrderBy(p => p.Position).ToList();
        }

        private void listBoxAvailablePlayers_DoubleClick(object sender, EventArgs e)
        {
            var player = Context.Players.Single(p => p.Id == ((Player)listBoxAvailablePlayers.SelectedItem).Id);
            var roster = Context.Rosters.Single(r => r.Id == Roster.Id);
            roster.Players.Add(player);
            player.Rosters.Add(roster);
            Context.SaveChanges();

            BindAvailablePlayers();
            BindRoster();
            SetRoundInfo();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            BindAvailablePlayers();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindAvailablePlayers();
        }

        private async void buttonRevert_Click(object sender, EventArgs e)
        {
            if (Picks <= 0) return;
            var lastIndex = (Index - 1)%Teams;
            var lastRoster = League.Rosters.ToList()[lastIndex];
            var lastPlayer = lastRoster.Players.Last();
            lastRoster.Players.Remove(lastPlayer);
            await Context.SaveChangesAsync();
            BindAvailablePlayers();
            BindRoster();
            SetRoundInfo();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            new Menu(this).Show();
        }

        private void comboBoxLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeDraft(false);
        }
    }
}
