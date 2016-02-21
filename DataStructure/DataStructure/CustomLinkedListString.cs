using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CustomLinkedListString : ICustomString
    {
        public CustomNode head;

        public CustomLinkedListString(CustomNode head)
        {
            this.head = head;
        }
        public void Insert(int index, string ToInsert)
        {
            char[] InsertAsArray = ToInsert.ToCharArray();
            CustomNode myNode = head;
            int indexer = 1;
            if (index == 0)
            {
                for (int i = 0; i < InsertAsArray.Length; i++)
                {
                    myNode = new CustomNode(InsertAsArray[InsertAsArray.Length - 1 - i], head);
                    head = myNode;
                }
            }
            else
            {
                while (indexer < index)
                {
                    myNode = myNode.next;
                    indexer++;
                }
                for (int i = 0; i < InsertAsArray.Length; i++)
                {
                    myNode.next = new CustomNode(InsertAsArray[i], myNode.next);
                    myNode = myNode.next;
                }
            }
        }

        public int Length()
        {
            CustomNode myNode = head;
            int incrementor = 0;
            if (myNode == null)
            {
                return 0;
            }
            while (myNode.next != null)
            {
                incrementor++;
                myNode = myNode.next;
            }
            return incrementor;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            CustomNode myNode = head;
            CustomNode skip = head;
            int indexer = 1;
            if(startIndex == 0)
            {
                for (int i = 0; i < numCharsToRemove; i++)
                {
                    myNode = myNode.next;
                }
                head = myNode;
            }
            else
            {
                while (indexer < startIndex)
                {
                    myNode = myNode.next;
                    skip = skip.next;
                    indexer++;
                }
                for (int i = 0; i < numCharsToRemove; i++)
                {
                    skip = skip.next;
                    myNode.next = skip;
                }
            }
        }
        public override string ToString()
        {
            CustomNode myNode = head;
            int count = Length();
            char[] myCharArray = new char[count];
            for (int i = 0; i < count; i++)
            {
                myCharArray[i] = (char)myNode.value;
            }
            return new string(myCharArray);
        }
    }
}
