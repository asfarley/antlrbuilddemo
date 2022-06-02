using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Diagnostics;

namespace Compiler
{
    public class Dummy
    {
        public void Compile(string path)
        {
            String input = File.ReadAllText(path);
            var str = new AntlrInputStream(input);
            var lexer = new TestlangLexer(str);
            var tokens = new CommonTokenStream(lexer);
            var parser = new TestlangParser(tokens);
            //var listener_lexer = new ML2LexerErrorListener<int>();
            //var listener_parser = new ML2ParserErrorListener();
            //lexer.RemoveErrorListeners();
            //parser.RemoveErrorListeners();
            //parser.RemoveErrorListeners();
            //lexer.AddErrorListener(listener_lexer);
            //parser.AddErrorListener(listener_parser);
            
            parser.BuildParseTree = true;

            var tree = parser.program_title();
            Trace.WriteLine(tree.ToStringTree(parser));

            //if (listener_lexer.had_error || listener_parser.had_error)
            //{
            //    Trace.WriteLine("Error in parse.");
            //}
            //else
            //{
            //    Trace.WriteLine("Parse completed.");
            //}
        }
    }
}