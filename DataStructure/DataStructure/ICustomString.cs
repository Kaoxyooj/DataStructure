using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public interface ICustomString
    {
        string ToString();
        void Insert(int index, string ToInsert);
        void Remove(int startIndex, int numCharsToRemove);
        int Length();
    }
}
