using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftManager.Models
{
    public class Roster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DraftOrder { get; set; }
        public bool IsMe { get; set; }
        public int LeagueId { get; set; }
        public virtual League League { get; set; }
        public virtual ICollection<Player> Players { get; set; }

        public Roster()
        {
            Players = new List<Player>();
        }

        public Roster(int league) : this()
        {
            LeagueId = league;
        }

        public override string ToString()
        {
            return $"{(IsMe ? "*" : " ")} {Name} ";
        }
    }
}
