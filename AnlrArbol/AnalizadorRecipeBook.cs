using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnlrArbol
{
    internal class AnalizadorRecipeBook : recipebookBaseVisitor<string>
    {
        public override string VisitEntry([NotNull] recipebookParser.EntryContext context)
        {
            Console.WriteLine(context.GetText());
            return base.VisitEntry(context);
        }
    }
}
