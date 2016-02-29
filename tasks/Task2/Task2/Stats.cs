using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Stats
    {
        public Stats(string hometeam, string awayteam, int score_hometeam, int score_awayteam)
        {
            if (string.IsNullOrWhiteSpace(hometeam)) throw new ArgumentException("Hometeam must not be empty", nameof(hometeam));
            if (string.IsNullOrWhiteSpace(awayteam)) throw new ArgumentException("Awayteam must not be empty", nameof(awayteam));

            Hometeam = hometeam;
            Awayteam = awayteam;
            Score_Hometeam = score_hometeam;
            Score_Awayteam = score_awayteam;
        }

        public string Hometeam { get; }

        public string Awayteam { get; }

        public int Score_Hometeam { get; }

        public int Score_Awayteam { get; }
    }
}

