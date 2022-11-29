using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    public interface SQLizable
    {
        static string ToSnakeCase(string camel)
        {
            string snake = "";
            foreach (char ch in camel)
            {
                int dif = 'A' - 'a';
                if (ch >= 'A' && ch <= 'Z')
                {
                    snake += $"_{(char)(ch - dif)}";
                } else
                {
                    snake += ch;
                }
            }
            if (snake[0] == '_')
            {
                snake = snake.Substring(1);
            }
            return snake;
        }
        public string TableName { get; }
        public string InsertValues { get; }
        public string ToInsertString()
        {
            return $"INSERT INTO {ToSnakeCase(TableName)} VALUES ({InsertValues});";
        }
    }
}
