using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class SystemString : ICustomString
    {
        public string theString;
        public SystemString(string theString)
        {
            this.theString = theString;
        }
        public void Insert(int index, string ToInsert)
        {
            theString.Insert(index, ToInsert);
        }

        public int Length()
        {
            return theString.Count();
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            theString.Remove(startIndex, numCharsToRemove);
        }
        public override string ToString()
        {
            return theString.ToString();
        }
    }
}
