using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DraftManager.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace DraftManager.Forms
{
    public partial class Menu : Form
    {
        private DraftContext context = new DraftContext();
        public Menu()
        {
            InitializeComponent();
            labelLoaded.Text = "";
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
                    var teamId = context.Teams.Single(t => t.Abbreviation == team).Id;
                    context.Players.AddOrUpdate(p => p.Rank, new Player
                    {
                        FirstName = first,
                        LastName = last,
                        Rank = rank,
                        TeamId = teamId,
                        Position = pos
                    });
                    row++;
                    labelLoaded.Text = $"Loaded: {row - 1}";

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                buttonLoadPlayers.Enabled = true;
                labelLoaded.Text = "Done";
                workbook.Close(false, Type.Missing, Type.Missing);
            }
        }

        private void buttonUpdatePlayers_Click(object sender, EventArgs e)
        {
            new UpdatePlayers().Show();
        }

        private void buttonInjuries_Click(object sender, EventArgs e)
        {
            new MarkInjuries().Show();
        }

        private void buttonNewLeague_Click(object sender, EventArgs e)
        {
            new NewLeague().Show();
        }

        private void buttonEditLeague_Click(object sender, EventArgs e)
        {
            if(context.Leagues.Count() > 0)
            {
                new EditLeague().Show();
            }
            else
            {
                MessageBox.Show("No leagues are configured.");
            }
        }
    }
}
