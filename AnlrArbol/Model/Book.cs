using AnlrArbol.Hacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    internal class Book
    {
        private List<Entry> entries;
        public List<IngredientUnit> ingredientUnits;

        public Book(List<Entry> nEntries)
        {
            List<List<IngredientUnit?>> allIngredientUnits = nEntries.Select(entry => entry.ingredients.Select(ing => ing.unit).ToList()).ToList();
            this.ingredientUnits = new List<IngredientUnit>();

            int ingredientCount = 0;
            int stepCount = 0;
            nEntries.ForEachIndexed((entry, idx) =>
            {
                entry.rec.id = idx;
                entry.ingredients.ForEach(ingredient =>
                {
                    IngredientUnit? newIngredientUnit = ingredient.unit;
                    if (newIngredientUnit != null)
                    {
                        IngredientUnit? matchedIngredientUnit = ingredientUnits.Find(ingredientUnit =>
                        {
                            return ingredientUnit.name == newIngredientUnit.name;
                        });
                        if (matchedIngredientUnit == null)
                        {
                            newIngredientUnit.id = ingredientUnits.Count;
                            ingredientUnits.Add(newIngredientUnit);
                        } else
                        {
                            ingredient.unit.id = matchedIngredientUnit.id;
                        }
                    }
                    ingredient.id = ingredientCount++;
                    ingredient.recipe.id = entry.rec.id;
                });
                entry.cookingSteps.ForEach(step =>
                {
                    step.id = stepCount++;
                    step.recipe.id = entry.rec.id;
                });
            });
            this.entries = nEntries;
        }

        public List<String> GetAllInserts()
        {
            List<String> inserts = new List<String>();
            ingredientUnits.ForEach(iu =>

                inserts.Add(((SQLizable)iu).ToInsertString())
            );
            entries.ForEach(entry =>
            {
                inserts.Add(((SQLizable)entry.rec).ToInsertString());
                entry.ingredients.ForEach(ing =>
                    inserts.Add(((SQLizable)ing).ToInsertString())
                );
                entry.cookingSteps.ForEach(cs =>
                    inserts.Add(((SQLizable)cs).ToInsertString())
                );
            });
            return inserts;
        }
    }
}
