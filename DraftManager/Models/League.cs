﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftManager.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Roster> Rosters { get; set; }
    }
}
