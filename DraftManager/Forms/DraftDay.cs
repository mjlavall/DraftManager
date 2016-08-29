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
    public partial class DraftDay : Form
    {
        private DraftContext context = new DraftContext();
        private League _league;
        private int _picks => selected?.Count ?? 0;
        private int _teams => _league?.Rosters?.Count ?? 0;
        private int _direction => (_picks / _teams) % 2 == 0 ? 1 : -1;
        private Roster _roster;
        private List<Player> selected;

        public DraftDay(League league)
        {
            InitializeComponent();
            _league = context.Leagues.Single(l => l.Id == league.Id);
            selected = new List<Player>();
            _league.Rosters.ToList().ForEach(r => selected.AddRange(r.Players.ToList()));
            var index = _direction > 0 ? _picks % _league.Rosters.Count : _teams - _picks % _league.Rosters.Count - 1;
            _roster = _league.Rosters.ToList()[index];
            BindAvailablePlayers();
            comboBoxFilter.DataSource = new List<string> { "ALL", "RB", "WR", "TE", "QB", "K", "D/ST" };
            SetRoundInfo();
            BindRoster();
        }

        private void SetRoundInfo()
        {
            labelRoundInfo.Text = $"Round {(_picks / _teams) + 1} - {_roster.Name}";
            labelCurrentTeam.Text = _roster.Name;
        }
    
        private void BindAvailablePlayers()
        {
            var available = context.Players.ToList().Where(p => selected.All(s => s.Id != p.Id)).ToList();
            var filterName = textBoxFilter.Text.ToUpper();
            var posFilter = (string) comboBoxFilter.SelectedItem;
            listBoxAvailablePlayers.DataSource = available.Where(p => p.Name.ToUpper().Contains(filterName) && (posFilter == "ALL" || posFilter == p.Position)).ToList();
        }

        private void BindRoster()
        {
            listBoxRoster.DataSource = _roster.Players.ToList();
            listBoxMyTeam.DataSource = _league.Rosters.Single(r => r.IsMe).Players.OrderBy(p => p.Position).ToList();
        }

        private void listBoxAvailablePlayers_DoubleClick(object sender, EventArgs e)
        {
            var player = context.Players.Single(p => p.Id == ((Player)listBoxAvailablePlayers.SelectedItem).Id);
            var roster = context.Rosters.Single(r => r.Id == _roster.Id);
            selected.Add(player);
            roster.Players.Add(player);
            player.Rosters.Add(roster);
            context.SaveChanges();

            var index = _direction > 0 ? _picks % _league.Rosters.Count : _teams - _picks % _league.Rosters.Count - 1;
            _roster = _league.Rosters.ToList()[index];
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
    }
}
