using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SystemArrayString : ICustomString
    {
        char[] myString;
        public SystemArrayString(char [] myString)
        {
            this.myString = myString;
        }
        public void Insert(int index, string ToInsert)
        {
            char[] tempChar =  ToInsert.ToCharArray();
            char[] myNewArray = new char[Length() + ToInsert.Length];
            for (int i = 0; i < index; i++)
            {
                myNewArray[i] = myString[i];
            }
            for (int i = index; i < tempChar.Length + index; i++)
            {
               myNewArray[i] = tempChar[i - index];
            }
            for (int i = index + tempChar.Count(); i < myNewArray.Count(); i++)
            {
                myNewArray[i] = myString[i - tempChar.Count()];
            }
            myString = myNewArray;
            foreach (char c in myString)
            {
                Console.WriteLine(c);
            }
        }

        public int Length()
        {
            return myString.Count();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] myNewArray = new char[Length() - numCharsToRemove];
            for (int i = 0; i < startIndex; i++)
            {
                myNewArray[i] = myString[i];
            }
            char[] myTempArray = new char[Length() - numCharsToRemove];
            myNewArray.CopyTo(myTempArray, 0);
            int incrementor = startIndex + numCharsToRemove;
            for (int i = startIndex; i < myTempArray.Length; i++)
            {
                myTempArray[i] = myString[incrementor];
                incrementor++;
            }
            myString = myTempArray;
            foreach (char item in myString)
            {
                Console.WriteLine(item);
            }
        }
        public override string ToString()
        {
            return new string(myString);
        }
    }
}
