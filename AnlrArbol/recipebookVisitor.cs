//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\kirot\source\repos\AnlrArbol\AnlrArbol\recipebook.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="recipebookParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IrecipebookVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.recipebook"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecipebook([NotNull] recipebookParser.RecipebookContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.book"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBook([NotNull] recipebookParser.BookContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.entry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEntry([NotNull] recipebookParser.EntryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.recipe_tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecipe_tag([NotNull] recipebookParser.Recipe_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.recipe_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecipe_name([NotNull] recipebookParser.Recipe_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.portions_tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPortions_tag([NotNull] recipebookParser.Portions_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.portion_unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPortion_unit([NotNull] recipebookParser.Portion_unitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.prep_time_tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrep_time_tag([NotNull] recipebookParser.Prep_time_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.cooking_time_tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCooking_time_tag([NotNull] recipebookParser.Cooking_time_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.calories_tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCalories_tag([NotNull] recipebookParser.Calories_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.calories_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCalories_content([NotNull] recipebookParser.Calories_contentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.calorie_unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCalorie_unit([NotNull] recipebookParser.Calorie_unitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.ingredients_tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIngredients_tag([NotNull] recipebookParser.Ingredients_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.ingredient_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIngredient_list([NotNull] recipebookParser.Ingredient_listContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.ingredient_list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIngredient_list_item([NotNull] recipebookParser.Ingredient_list_itemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.ingredient"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIngredient([NotNull] recipebookParser.IngredientContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.measure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMeasure([NotNull] recipebookParser.MeasureContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.ingredient_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIngredient_name([NotNull] recipebookParser.Ingredient_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.elaboration_tag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElaboration_tag([NotNull] recipebookParser.Elaboration_tagContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.elaboration_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElaboration_list([NotNull] recipebookParser.Elaboration_listContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.elaboration_list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElaboration_list_item([NotNull] recipebookParser.Elaboration_list_itemContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.list_order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList_order([NotNull] recipebookParser.List_orderContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrder([NotNull] recipebookParser.OrderContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.instruction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInstruction([NotNull] recipebookParser.InstructionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.time"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime([NotNull] recipebookParser.TimeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.time_unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime_unit([NotNull] recipebookParser.Time_unitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.amount"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAmount([NotNull] recipebookParser.AmountContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recipebookParser.text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitText([NotNull] recipebookParser.TextContext context);
}
