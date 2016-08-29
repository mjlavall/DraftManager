using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftManager.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Rank { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public string Position { get; set; }
        public bool Injured { get; set; }
        public bool Out { get; set; }
        public virtual ICollection<Roster> Rosters { get; set; }

        public string Name => $"{FirstName} {LastName}";
        public void RaiseRank() => Rank++;
        public void LowerRank() => Rank--;
        public override string ToString() => $"[{Rank}]{(Rank < 100 ? (Rank < 10 ? "  " : " ") : "")} {Position}{(Position.Length < 4 ? (Position.Length < 2 ? "   " : "  ") : "")} {FirstName} {LastName} ({Team.Abbreviation} {Team.Bye})";
    }
}
