using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cha = { 'k', 'a', 'o', 'x', 'i', 'o', 'n', 'g' };

            SystemString sysString = new SystemString("Pointless");
            sysString.Insert(3, "Super");

            SystemArrayString ars = new SystemArrayString(cha);
            ars.Insert(2, "Point");
            ars.Insert(4, "This");

            LinkedList<char> hi = new LinkedList<char>();
            SystemLinkedListString sys = new SystemLinkedListString(hi);
            hi.AddFirst('1');
            hi.AddLast('5');
            hi.AddLast('6');
            sys.Insert(1, "2");
            sys.Insert(2, "3");
            sys.Insert(3, "4");
            sys.Remove(1, 4);

            CustomLinkedListString custom = new CustomLinkedListString(new CustomNode('k', null));
            custom.head.next = new CustomNode('a', null);
            custom.head.next.next = new CustomNode('b', null);
            custom.Insert(1, "h");
            custom.Insert(3, "are");
            Console.WriteLine(custom.ToString());

            SortedList<int, ICustomString> sorted = new SortedList<int, ICustomString>();
            sorted.Add(sysString.Length(), sysString);
            sorted.Add(ars.Length(), ars);
            sorted.Add(sys.Length(), sys);
            sorted.Add(custom.Length(), custom);

            Sweepstakes sweeps = new Sweepstakes("Win or not!");
            sweeps.RegisterContestant(new Contestant("Kao"));
            sweeps.RegisterContestant(new Contestant("Elon"));
            sweeps.RegisterContestant(new Contestant("Cloud"));
            sweeps.RegisterContestant(new Contestant("Tidus"));
            sweeps.RegisterContestant(new Contestant("Squall"));
            sweeps.RegisterContestant(new Contestant("MG"));
            Contestant NewPlayerHasJoined = new Contestant("Sephiroth");
            sweeps.PrintConstestantInfo(NewPlayerHasJoined);
            string winner = sweeps.PickWinner();
            Console.WriteLine(winner);
            Console.ReadLine();
        }
    }
}
