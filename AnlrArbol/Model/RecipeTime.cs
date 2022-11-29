using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    internal class RecipeTime
    {
        public int amount;
        public TIME_UNIT unit;
        public RecipeTime(int amount, int unit)
        {
            this.amount = amount;
            this.unit = (TIME_UNIT)(unit/2);
        }
    }

    enum TIME_UNIT
    {
        MINUTES,
        SECONDS,
        HOURS,
        DAYS
    }
}
