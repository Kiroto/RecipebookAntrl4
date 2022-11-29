using AnlrArbol.Hacks;
using AnlrArbol.Model;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Double = AnlrArbol.Hacks.Double;

namespace AnlrArbol
{
    internal class AnalizadorRecipeBook : recipebookBaseVisitor<object>
    {

        public override Double VisitAmount([NotNull] recipebookParser.AmountContext context)
        {
            return double.Parse(context.GetText());
        }

        public override Book VisitBook([NotNull] recipebookParser.BookContext context)
        {
            List<Entry> entryList = context.entry().Select((ctx, id) => VisitEntry(ctx)).ToList();
            return new Book(entryList);
        }

        public override Int VisitCalories_content([NotNull] recipebookParser.Calories_contentContext context)
        {
            return VisitAmount(context.amount());
        }

        public override Int VisitCalories_tag([NotNull] recipebookParser.Calories_tagContext context)
        {
            return VisitCalories_content(context.calories_content());
        }

        public override RecipeTime? VisitCooking_time_tag([NotNull] recipebookParser.Cooking_time_tagContext context)
        {
            return context != null ? VisitTime(context.time()) : null;
        }

        public override List<CookingStep> VisitElaboration_list([NotNull] recipebookParser.Elaboration_listContext context)
        {
            return context.elaboration_list_item().Select((ctx, id) => VisitElaboration_list_item(ctx)).ToList();
        }

        public override CookingStep VisitElaboration_list_item([NotNull] recipebookParser.Elaboration_list_itemContext context)
        {
            return new CookingStep(-1, null, VisitList_order(context.list_order()), VisitInstruction(context.instruction()));
        }

        public override List<CookingStep> VisitElaboration_tag([NotNull] recipebookParser.Elaboration_tagContext context)
        {
            return VisitElaboration_list(context.elaboration_list());
        }

        public override Entry VisitEntry([NotNull] recipebookParser.EntryContext context)
        {

            Recipe rec = new Recipe(
                -1,
                VisitRecipe_tag(context.recipe_tag()),
                VisitPortions_tag(context.portions_tag()),
                VisitPrep_time_tag(context.prep_time_tag()),
                VisitCooking_time_tag(context.cooking_time_tag()),
                VisitCalories_tag(context.calories_tag())
            );

            List<Ingredient> ingredients = VisitIngredients_tag(context.ingredients_tag());
            ingredients.ForEach(ing => ing.recipe = rec);

            List<CookingStep> cookingSteps = VisitElaboration_tag(context.elaboration_tag());
            cookingSteps.ForEach(cs => cs.recipe = rec);

            return new Entry(rec, ingredients, cookingSteps);
        }

        public override IngredientMeasureName VisitIngredient([NotNull] recipebookParser.IngredientContext context)
        {
            return new IngredientMeasureName(VisitIngredient_name(context.ingredient_name()), VisitMeasure(context.measure()));
        }

        public override List<Ingredient> VisitIngredients_tag([NotNull] recipebookParser.Ingredients_tagContext context)
        {
            return VisitIngredient_list(context.ingredient_list());
        }

        public Book Visit(IParseTree tree)
        {
            return (Book)tree.Accept(this);
        }

        public override List<Ingredient> VisitIngredient_list([NotNull] recipebookParser.Ingredient_listContext context)
        {
            return context.ingredient_list_item().Select((ctx, index) => VisitIngredient_list_item(ctx)).ToList();
        }

        public override Ingredient VisitIngredient_list_item([NotNull] recipebookParser.Ingredient_list_itemContext context)
        {
            IngredientMeasureName measureName = VisitIngredient(context.ingredient());
            return new Ingredient(-1, measureName.Name, null, VisitAmount(context.amount()), measureName.Measure);
        }

        public override string VisitIngredient_name([NotNull] recipebookParser.Ingredient_nameContext context)
        {
            return context.GetText();
        }

        public override string VisitInstruction([NotNull] recipebookParser.InstructionContext context)
        {
            return context.GetText();
        }

        public override Int VisitList_order([NotNull] recipebookParser.List_orderContext context)
        {
            return VisitOrder(context.order());
        }

        public override IngredientUnit? VisitMeasure([NotNull] recipebookParser.MeasureContext context)
        {
            return context != null ? new IngredientUnit(-1, context.GetText()) : null;
        }

        public override Int VisitOrder([NotNull] recipebookParser.OrderContext context)
        {
            return int.Parse(context.GetText());
        }

        public override Int VisitPortions_tag([NotNull] recipebookParser.Portions_tagContext context)
        {
            return VisitAmount(context.amount());
        }

        public override RecipeTime? VisitPrep_time_tag([NotNull] recipebookParser.Prep_time_tagContext context)
        {
            return context != null ? VisitTime(context.time()) : null;
        }

        public override Book VisitRecipebook([NotNull] recipebookParser.RecipebookContext context)
        {
            return VisitBook(context.book());
        }

        public override string VisitRecipe_name([NotNull] recipebookParser.Recipe_nameContext context)
        {
            return context.GetText();
        }

        public override string VisitRecipe_tag([NotNull] recipebookParser.Recipe_tagContext context)
        {
            return VisitRecipe_name(context.recipe_name());
        }

        public override RecipeTime? VisitTime([NotNull] recipebookParser.TimeContext context)
        {
            return context != null ? new RecipeTime(VisitAmount(context.amount()), VisitTime_unit(context.time_unit())) : null;
        }

        public override Int VisitTime_unit([NotNull] recipebookParser.Time_unitContext context)
        {
            return context.getAltNumber();
        }
    }
}
