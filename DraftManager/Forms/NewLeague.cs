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
    public partial class NewLeague : Form
    {
        private DraftContext context = new DraftContext();

        public NewLeague()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void buttonAddLeague_Click(object sender, EventArgs e)
        {
            var leagueName = textBoxLeague.Text;
            textBoxLeague.Text = "";
            if (string.IsNullOrEmpty(leagueName)) return;
            if (context.Leagues.Any(l => l.Name.Equals(leagueName, StringComparison.CurrentCultureIgnoreCase))) return;
            context.Leagues.Add(new League {Name = leagueName});
            context.SaveChanges();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxLeagues.DataSource = context.Leagues.OrderBy(l => l.Name).ToList();
            listBoxLeagues.DisplayMember = "Name";
        }
    }
}
