using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnlrArbol.Model
{
    internal class CookingStep : SQLizable
    {
        public int id;
        public Recipe recipe;
        int stepNumber;
        string description;

        public CookingStep(int id, Recipe recipe, int stepNumber, string description)
        {
            this.id = id;
            this.recipe = recipe;
            this.stepNumber = stepNumber;
            this.description = description;
        }

        public string TableName => "CookingSteps";

        string SQLizable.InsertValues => $"{id}, {recipe.id}, {stepNumber}, \"{description}\"";
    }
}
