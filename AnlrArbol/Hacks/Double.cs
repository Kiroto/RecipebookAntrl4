using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Hacks
{
    internal class Double
    {
        double value;

        public Double(double value)
        {
            this.value = value;
        }

        public static implicit operator double(Double i) => i.value;
        public static implicit operator Double(double i) => new Double(i);
        public static implicit operator int(Double d) => (int)d.value;
        public static implicit operator Int(Double d) => new Int((int)d.value);
    }
}
