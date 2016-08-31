using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DraftManager.Models;

namespace DraftManager.Forms
{
    public partial class MarkInjuries : Form
    {
        private IEnumerable<Player> Injured => _draft?.Context.Players.Where(p => p.Injured).ToList();
        private IEnumerable<Player> Healthy => _draft?.Context.Players.Where(p => !p.Injured).ToList();
        private readonly DraftDay _draft;

        public MarkInjuries(DraftDay draft)
        {
            InitializeComponent();
            _draft = draft;
            BindPlayers();
        }

        private void BindPlayers()
        {
            textBoxHealthy.Text = textBoxInjured.Text = "";
            BindHealthy();
            BindInjured();
        }

        private void BindHealthy()
        {
            listBoxHealthy.DataSource = Healthy.Where(p => p.Name.ToUpper().Contains(textBoxHealthy.Text.ToUpper())).OrderBy(p => p.Rank).ToList();
        }

        private void BindInjured()
        {
            listBoxInjured.DataSource = Injured.Where(p => p.Name.ToUpper().Contains(textBoxInjured.Text.ToUpper())).OrderBy(p => p.Rank).ToList();
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
            var player = listBoxHealthy.SelectedItem as Player;
            if (player != null) player.Injured = true;
            _draft?.Context.SaveChanges();
            BindHealthy();
            BindInjured();
            _draft?.InitializeDraft();
        }

        private void listBoxInjured_DoubleClick(object sender, EventArgs e)
        {
            var player = listBoxInjured.SelectedItem as Player;
            if (player != null) player.Injured = false;
            _draft?.Context.SaveChanges();
            BindHealthy();
            BindInjured();
            _draft?.InitializeDraft();
        }
    }
}
