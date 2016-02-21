using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepsQueue = new Queue<Sweepstakes>();
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepsQueue.Dequeue();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepsQueue.Enqueue(sweepstakes);
        }
    }
}
