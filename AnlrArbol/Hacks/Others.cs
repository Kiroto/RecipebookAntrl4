using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol.Hacks
{
    static class Others
    {
        public static T Apply<T>(this T t, Action<T> toDo)
        {
            toDo(t);
            return t;
        }

        public static void ForEachIndexed<T>(this List<T> l, Action<T, int> toDo)
        {
            int max = l.Count;
            for (int i = 0; i < max; i++)
            {
                toDo(l[i], i);
            }
        }
    }
}
