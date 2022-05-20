using ConsoleApp1.Content;

namespace ConsoleApp1;

public class C2022V2Visitor : c2022v2BaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new();

    public override object? VisitAssignment(c2022v2Parser.AssignmentContext context)
    {
        var varName = context.IDENTIFIER().GetText();
        var value = Visit(context.expression());

        Variables[varName] = value;
        
        return null;
    }
    
    
}