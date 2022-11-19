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
        public override string VisitCalories_content([NotNull] recipebookParser.Calories_contentContext context)
        {
            Console.WriteLine(context.GetText());
            return base.VisitCalories_content(context);
        }

        public override string VisitElaboration_list([NotNull] recipebookParser.Elaboration_listContext context)
        {
            return base.VisitElaboration_list(context);
        }

        public override string VisitElaboration_list_item([NotNull] recipebookParser.Elaboration_list_itemContext context)
        {
            return base.VisitElaboration_list_item(context);
        }

        public override string VisitElaboration_tag([NotNull] recipebookParser.Elaboration_tagContext context)
        {
            return base.VisitElaboration_tag(context);
        }

        public override string VisitIngredient_list([NotNull] recipebookParser.Ingredient_listContext context)
        {
            return base.VisitIngredient_list(context);
        }

        public override string VisitIngredient_list_item([NotNull] recipebookParser.Ingredient_list_itemContext context)
        {
            return base.VisitIngredient_list_item(context);
        }

        public override string VisitIngredient_name([NotNull] recipebookParser.Ingredient_nameContext context)
        {
            return base.VisitIngredient_name(context);
        }
    }
}
