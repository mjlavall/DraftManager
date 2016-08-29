using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftManager.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Abbreviation { get; set; }
        public int Bye { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
