using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestDic = new Dictionary<int, Contestant>();

        string contestantName;
        public Sweepstakes(string contestantName)
        {
            this.contestantName = contestantName;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestDic.Add(contestDic.Count, contestant);
        }
        public string PickWinner()
        {
            Random random = new Random();
            int randomNum = random.Next(contestDic.Count);
            Contestant win = contestDic[randomNum];
            return win.name;
        }
        public void PrintConstestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.ToString());
        }
    }
}
