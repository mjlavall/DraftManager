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
    public partial class MarkInjuries : Form
    {
        DraftContext context = new DraftContext();
        private List<Player> injured = new List<Player>();
        private List<Player> healthy = new List<Player>();
        public MarkInjuries()
        {
            InitializeComponent();
            BindPlayers();
        }

        private void BindPlayers()
        {
            textBoxHealthy.Text = textBoxInjured.Text = "";
            injured = context.Players.Where(p => p.Injured).ToList();
            healthy = context.Players.Where(p => !p.Injured).ToList();
            BindHealthy();
            BindInjured();
        }

        private void BindHealthy()
        {
            listBoxHealthy.DataSource = healthy.Where(p => p.Name.ToUpper().Contains(textBoxHealthy.Text.ToUpper())).OrderBy(p => p.Rank).ToList();
            listBoxHealthy.DisplayMember = "Name";
        }

        private void BindInjured()
        {
            listBoxInjured.DataSource = injured.Where(p => p.Name.ToUpper().Contains(textBoxInjured.Text.ToUpper())).OrderBy(p => p.Rank).ToList();
            listBoxInjured.DisplayMember = "Name";
        }

        private void textBoxHealthy_TextChanged(object sender, EventArgs e)
        {
            BindHealthy();
        }

        private void textBoxInjured_TextChanged(object sender, EventArgs e)
        {
            BindInjured();
        }

        private void listBoxHealthy_DoubleClick(object sender, EventArgs e)
        {
            var player = (Player) listBoxHealthy.SelectedItem;
            var dbPlayer = context.Players.Single(p => p.Id == player.Id);
            dbPlayer.Injured = true;
            context.SaveChanges();
            injured.Add(player);
            healthy.Remove(player);
            BindHealthy();
            BindInjured();
        }

        private void listBoxInjured_DoubleClick(object sender, EventArgs e)
        {
            var player = (Player)listBoxInjured.SelectedItem;
            var dbPlayer = context.Players.Single(p => p.Id == player.Id);
            dbPlayer.Injured = false;
            context.SaveChanges();
            healthy.Add(player);
            injured.Remove(player);
            BindHealthy();
            BindInjured();
        }
    }
}
