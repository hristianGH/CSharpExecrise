﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    class Town
    {
        //public Town()
        //{
        //    Teams = new HashSet<Team>();
        //}
        public int TownId { get; set; }
        public string Name { get; set; }
        public virtual Country Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
