using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic.Stack;

namespace DataStructure
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepStack = new Stack<Sweepstakes>();
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepStack.Pop();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepStack.Push(sweepstakes);
        }
    }
}
