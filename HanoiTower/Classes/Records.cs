using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTower
{
    class Records
    {
        private int playerScore;
        public int PlayerScore
        {
            get { return playerScore; }
            set { playerScore = value; }
        }

        private string playerName;
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private string elapsedPlayingTime;
        public string ElapsedPlayingTime
        {
            get { return elapsedPlayingTime; }
            set { elapsedPlayingTime = value; }
        }

        private int elapsedMinutes;
        public int ElapsedMinutes
        {
            get { return elapsedMinutes; }
            set { elapsedMinutes = value; }
        }

        private int elapsedSeconds;
        public int ElapsedSeconds
        {
            get { return elapsedSeconds; }
            set { elapsedSeconds = value; }
        }

        private int lowestMinute;
        public int LowestMinute
        {
            get { return lowestMinute; }
            set { lowestMinute = value; }
        }

        private int lowestSecond;
        public int LowestSecond
        {
            get { return lowestSecond; }
            set { lowestSecond = value; }
        }

        private int lowestScore;
        public int LowestScore
        {
            get { return lowestScore; }
            set { lowestScore = value; }
        }

        private string[] line;
        public string[] Line
        {
            get { return line; }
            set { line = value; }
        }

        private List<string> players;
	    public List<string> Players
	    {
		    get { return players;}
		    set { players = value;}
	    }

        private List<int> scores;
	    public List<int> Scores
	    {
		    get { return scores;}
		    set { scores = value;}
	    }

        private List<int> minutes;
        public List<int> Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        private List<int> seconds;
        public List<int> Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        
    }
}
