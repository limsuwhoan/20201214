﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Ranking1 : IComparable
    {
        private int rank;
        private int score;
        private string name;

        public int Rank { get => rank; set => rank = value; }
        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }

        public int CompareTo(object obj)
        {
            return (obj as Ranking1).score.CompareTo(this.score);
        }
    }
}
