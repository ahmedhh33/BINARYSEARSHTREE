using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeInOrder
{
    internal class Nodes
    {
        public int item;
        public Nodes Right;
        public Nodes Left;

        public Nodes(int item)
        { this.item = item; }
        
    }
}
