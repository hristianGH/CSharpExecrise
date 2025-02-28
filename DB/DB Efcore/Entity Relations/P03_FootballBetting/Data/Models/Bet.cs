﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    class Bet
    {
        public int BetId { get; set; }
        public decimal Amount { get; set; }
        public double Prediction { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Game Game { get; set; }
        public int GameId { get; set; }
       
    }
}
//BetId, Amount, Prediction, DateTime, UserId, GameId