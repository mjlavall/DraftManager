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
    public partial class DraftDayLeagueSelect : Form
    {
        private DraftContext context = new DraftContext();

        public DraftDayLeagueSelect()
        {
            InitializeComponent();
            comboBoxLeagues.DataSource = context.Leagues.OrderBy(l => l.Name).ToList();
            comboBoxLeagues.DisplayMember = "Name";
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            new DraftDay((League)comboBoxLeagues.SelectedItem).Show();
            Close();
        }
    }
}
