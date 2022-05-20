using Antlr4.Runtime;
using ConsoleApp1;
using ConsoleApp1.Content;

var fileName = "Content\\test.c2022v2";
var fileContents = File.ReadAllText(fileName);

var inputStream = new AntlrInputStream(fileContents);

var c2022V2Lexer = new c2022v2Lexer(inputStream);
var commonTokenStream = new CommonTokenStream(c2022V2Lexer);
var c2022V2Parser = new c2022v2Parser(commonTokenStream);
var programContext = c2022V2Parser.program();
var visitor = new C2022V2Visitor();

visitor.Visit(programContext);