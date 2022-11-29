using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Model
{
    public interface SQLizable
    {
        public string TableName { get; }
        public string InsertValues { get; }
        public string ToInsertString()
        {
            return $"INSERT INTO {TableName} VALUES ({InsertValues});";
        }
    }
}
