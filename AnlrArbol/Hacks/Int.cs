using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Hacks
{
    internal class Int
    {
        int value;

        public Int(int value)
        {
            this.value = value;
        }

        public static implicit operator int(Int i) => i.value;
        public static implicit operator Int(int i) => new Int(i);
    }
}
