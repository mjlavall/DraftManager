using System;
using System.Linq;
using System.Windows.Forms;
using DraftManager.Models;

namespace DraftManager.Forms
{
    public partial class NewLeague : Form
    {
        private readonly DraftDay _draft;

        public NewLeague(DraftDay draft)
        {
            InitializeComponent();
            _draft = draft;
            UpdateListBox();
        }

        private void buttonAddLeague_Click(object sender, EventArgs e)
        {
            var leagueName = textBoxLeague.Text;
            textBoxLeague.Text = "";
            if (string.IsNullOrEmpty(leagueName)) return;
            if (_draft != null && _draft.Context.Leagues.Any(l => l.Name.Equals(leagueName, StringComparison.CurrentCultureIgnoreCase))) return;
            _draft?.Context.Leagues.Add(new League {Name = leagueName});
            _draft?.Context.SaveChanges();
            UpdateListBox();
            _draft?.InitializeDraft();
        }

        private void UpdateListBox()
        {
            listBoxLeagues.DataSource = _draft?.Context.Leagues.OrderBy(l => l.Name).ToList();
        }
    }
}
