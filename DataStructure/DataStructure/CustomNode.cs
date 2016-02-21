using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CustomNode
    {
        public char value;
        public CustomNode next;

        public CustomNode(char value, CustomNode next)
        {
            this.value = value;
            this.next = next;
        }

    }
}
