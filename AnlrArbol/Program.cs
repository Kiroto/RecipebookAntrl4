using AnlrArbol;
using Antlr4.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        ICharStream testingFile = CharStreams.fromPath(@"..\..\..\receta.txt");
        var lexer = new recipebookLexer(testingFile);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new recipebookParser(tokenStream);
        var tree = parser.recipebook();

        var visitor = new AnalizadorRecipeBook();
        var rtrn = visitor.Visit(tree);
        rtrn.GetAllInserts().ForEach( insert =>
            Console.WriteLine(insert));
        Console.ReadLine();
    }
}