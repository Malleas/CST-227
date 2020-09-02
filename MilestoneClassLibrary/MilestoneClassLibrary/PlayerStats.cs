using System;
using System.Collections.Generic;
using System.Text;

namespace MilestoneClassLibrary
{
    public class PlayerStats : IComparable<PlayerStats>
    {
        public string playerInitials { get; set; }
        public string gameDifficulty { get; set; }
        public string timeElapsed { get; set; }
        public int score { get; set; }

        public int CompareTo(PlayerStats other)
        {
            if(this.score == other.score)
            {
                return this.playerInitials.CompareTo(other.playerInitials);
            }
            return other.score.CompareTo(this.score);
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} {2} {3} ", playerInitials, gameDifficulty, timeElapsed, score);
            }
        }
    }
}
