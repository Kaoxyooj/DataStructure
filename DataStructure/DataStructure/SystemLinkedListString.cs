using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SystemLinkedListString : ICustomString
    {
        LinkedList<char> linkedlist;

        public SystemLinkedListString(LinkedList<char> linkedlist)
        {
            this.linkedlist = linkedlist;
        }
        public void Insert(int index, string ToInsert)
        {
            char[] Insertion = ToInsert.ToCharArray();
            LinkedListNode<char> node = linkedlist.First;
            int theIndex = 0;

            while (theIndex < index)
            {
                node = node.Next;
                theIndex++;
            }
            node = node.Previous;
            if (linkedlist == null || Insertion == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 0; i < Insertion.Length; i++)
                {
                    linkedlist.AddAfter(node, Insertion[i]);
                    node = node.Next;
                }
            }
        }

        public int Length()
        {
            return linkedlist.Count;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            LinkedListNode<char> node = linkedlist.First;
            int indexI = 0;
            int incrementor = 0;

            if (startIndex == 0)
            {
                for (incrementor = 0; incrementor < numCharsToRemove; incrementor++)
                {
                    linkedlist.RemoveFirst();
                }
            }
            else
            {
                while (indexI < startIndex)
                {
                    node = node.Next;
                    indexI++;
                }
                node = node.Previous;
                for (incrementor = 0; incrementor < numCharsToRemove; incrementor++)
                {
                    if (node != null)
                    {
                    linkedlist.Remove(node.Next);
                    }
                }
            }
        }
        public override string ToString()
        {
            return new string(linkedlist.ToArray());
        }

    }
}
