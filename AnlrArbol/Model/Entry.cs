using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    internal class Entry
    {
        public Recipe rec;
        public List<Ingredient> ingredients;
        public List<CookingStep> cookingSteps;

        public Entry(Recipe rec, List<Ingredient> ingredients, List<CookingStep> cookingSteps)
        {
            this.rec = rec;
            this.ingredients = ingredients;
            this.cookingSteps = cookingSteps;
        }
    }
}
