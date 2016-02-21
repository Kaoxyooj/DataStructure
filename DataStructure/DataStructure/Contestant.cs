using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Contestant
    {
        public string name;
        public Contestant(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
