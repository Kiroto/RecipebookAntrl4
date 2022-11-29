using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    internal class Recipe : SQLizable
    {

        public int id;
        string name;
        int portions;
        RecipeTime? prepTime;
        RecipeTime? cookTime;
        int calories;

        public Recipe(int id, string name, int portions, RecipeTime? prepTime, RecipeTime? cookTime, int calories)
        {
            this.id = id;
            this.name = name;
            this.portions = portions;
            this.prepTime = prepTime;
            this.cookTime = cookTime;
            this.calories = calories;
        }

        public string TableName { get => "Recipes"; }
        string SQLizable.InsertValues => InsertValueGen();

        private string InsertValueGen()
        {
            string cookTimeAmount = "null";
            string cookTimeUnit = "null";
            string prepTimeAmount = "null";
            string prepTimeUnit = "null";

            if (cookTime != null)
            {
                cookTimeAmount =    cookTime.amount.ToString();
                cookTimeUnit =      $"\"{cookTime.unit.ToString()}\"";
            }
            if (prepTime != null)
            {
                prepTimeAmount = prepTime.amount.ToString();
                prepTimeUnit = $"\"{prepTime.unit.ToString()}\"";
            }

            return $"{id}, \"{name}\", {portions}, {prepTimeAmount}, {prepTimeUnit}, {cookTimeAmount}, {cookTimeUnit}, {calories}";
        }
    }
}
