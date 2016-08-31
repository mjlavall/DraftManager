using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using DraftManager.Models;
using DraftManager.Properties;
using Excel = Microsoft.Office.Interop.Excel;

namespace DraftManager.Forms
{
    public partial class Menu : Form
    {
        private readonly DraftDay _draft;

        public Menu(DraftDay draft)
        {
            InitializeComponent();
            labelLoaded.Text = "";
            _draft = draft;
        }

        private void buttonLoadPlayers_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var file = ofd.FileName;
                    buttonLoadPlayers.Enabled = false;
                    LoadPlayers(file);
                }
            }
        }

        private void LoadPlayers(string filename)
        {
            var excel = new Excel.Application();
            var workbook = excel.Workbooks.Open(filename);
            var worksheet = workbook.ActiveSheet;

            try
            {
                var row = 2;
                while (worksheet.Cells[row, 1].Value.ToString() != "END")
                {
                    var rank = int.Parse(worksheet.Cells[row, 1].Value.ToString());
                    var name = worksheet.Cells[row, 2].Value.ToString().Split(' ');
                    var first = name[0];
                    var last = name.Length > 1 ? name[1] : "";
                    var pos = worksheet.Cells[row, 3].Value.ToString();
                    string team = worksheet.Cells[row, 4].Value.ToString();
                    var teamId = _draft?.Context.Teams.Single(t => t.Abbreviation == team).Id ?? 0;
                    _draft?.Context.Players.AddOrUpdate(p => p.Rank, new Player
                    {
                        FirstName = first,
                        LastName = last,
                        Rank = rank,
                        TeamId = teamId,
                        Position = pos
                    });
                    row++;
                    labelLoaded.Text = $"Loaded: {row - 1}";

                    _draft?.Context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                buttonLoadPlayers.Enabled = true;
                labelLoaded.Text = Resources.Menu_LoadPlayers_Done;
                workbook.Close(false, Type.Missing, Type.Missing);
            }
        }

        private void buttonUpdatePlayers_Click(object sender, EventArgs e)
        {
            new UpdatePlayers(_draft).Show();
        }

        private void buttonInjuries_Click(object sender, EventArgs e)
        {
            new MarkInjuries(_draft).Show();
        }

        private void buttonNewLeague_Click(object sender, EventArgs e)
        {
            new NewLeague(_draft).Show();
        }

        private void buttonEditLeague_Click(object sender, EventArgs e)
        {
            if(_draft != null && _draft.Context.Leagues.Any())
            {
                new EditLeague(_draft).Show();
            }
            else
            {
                MessageBox.Show(Resources.Menu_buttonEditLeague_Click_No_leagues_are_configured_);
            }
        }
    }
}
