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

    public override object? VisitConstant(c2022v2Parser.ConstantContext context)
    {
        if (context.INTEGER() is { } i)
        {
            return int.Parse(i.GetText());
        }
    
        if (context.DOUBLE() is { } d)
        {
            return double.Parse(d.GetText());
        }
        
        if (context.CHAR() is { } c)
        {
            return char.Parse(c.GetText());
        }
        
        if (context.BOOL() is { } b)
        {
            return b.GetText() == "true";
        }
    
        if (context.NULL() is { })
        {
            return null;
        }
    
        throw new NotImplementedException();
    }
}