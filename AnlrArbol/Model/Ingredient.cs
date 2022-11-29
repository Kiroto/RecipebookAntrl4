using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    internal class Ingredient : SQLizable
    {

        public int id;
        public string name;
        public Recipe recipe;
        double quantity;
        public IngredientUnit? unit;

        public Ingredient(int id, string name, Recipe recipe, double quantity, IngredientUnit? unit)
        {
            this.id = id;
            this.name = name;
            this.recipe = recipe;
            this.quantity = quantity;
            this.unit = unit;
        }

        public string TableName => "Ingredient";

        public string InsertValues => $"{id}, {recipe.id}, {name}, {quantity}, {(unit != null ? unit.id.ToString() : "null")}";
    }
}
