using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    internal class IngredientMeasureName
    {
        public string Name;
        public IngredientUnit Measure;

        public IngredientMeasureName(string name, IngredientUnit measure)
        {
            Name = name;
            Measure = measure;
        }
    }
}
