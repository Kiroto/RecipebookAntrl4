using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    internal class IngredientUnit : SQLizable
    {
        public int id;
        public string name;

        private string standardise(string s)
        {
            if (s.EndsWith("s"))
            {
                int len = s.Length;
                s = s.Remove(len - 1, 1);
            };
            return s.ToLower(); ;

        }

        public IngredientUnit(int id, string name)
        {
            this.id = id;
            this.name = standardise(name);
        }

        public string TableName => "IngredientUnit";

        public string InsertValues => $"{id}, '{name}'";
    }
}
