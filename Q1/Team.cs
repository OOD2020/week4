using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q1 
{
    public enum Result { Win, Draw, Loss}
    public class Team : IComparable
    {


        #region Properties
        private int _points;
        public string TeamName { get; private set; }
        public int Wins { get; private set; }
        public int Draws { get; private set; }
        public int Losses { get; private set; }
        public int Games { get; private set; }

        public int Points
        {
            get
            {
                _points = (Wins * 3) + (Draws * 1);
                return _points;
            }
        }
        public List<Player> Players { get;  set; }
        //WHY IS THIS RED UNDERLINED????????

        #endregion Properties

        public Team(string n)
        {
            TeamName = n;
            Players = new List<Player>();
        }
        public string DisplayTeamTable()
        {
            return string.Format($"{TeamName,-15}{Points,-7}{Wins,-7}{Draws, - 7}{Losses,-7}{Games,-7}");
        }
        public void AddResult(Result result)
        {
            Games++;

            switch(result)
            {
                case Result.Win:
                    Wins++;
                    break;

                case Result.Loss:
                    Losses++;
                    break;

                case Result.Draw:
                    Draws++;
                    break;

            }

        }
        public int CompareTo(object obj)
        {
            Team that = (Team)obj;

            return this.Points.CompareTo(that.Points);
            //the "Team" object is comparing itself to another object that's beside it in a list
            //to see if it should change the positioning/reorder where the object stands in the list
        }
    }
}
