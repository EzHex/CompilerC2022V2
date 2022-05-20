using System.Diagnostics;
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
        
        return value;
    }

    public override object? VisitConstantExpression(c2022v2Parser.ConstantExpressionContext context)
    {
        var constant = context.constant();
        if (constant is { } con)
        {
            if (constant.INTEGER() is { } i)
            {
                return int.Parse(i.GetText());
            }

            if (constant.DOUBLE() is { } d)
            {
                return double.Parse(d.GetText());
            }
    
            if (constant.CHAR() is { } c)
            {
                return char.Parse(c.GetText().Trim('\''));
            }
    
            if (constant.BOOL() is { } b)
            {
                return b.GetText() == "true";
            }

            if (constant.NULL() is { })
            {
                return null;
            }

        }

        throw new NotImplementedException();
    }

    public override object? VisitIdentifierExpression(c2022v2Parser.IdentifierExpressionContext context)
    {
        var varName = context.IDENTIFIER().GetText();
        if (Variables.ContainsKey(varName))
        {
            var value = Variables[varName]; 
            return value;
        }
        else
        {

            throw new Exception("nu va nera tokio kintamo :(");
        }
    }

    public override object? VisitParenthesesExpression(c2022v2Parser.ParenthesesExpressionContext context)
    {
        return Visit(context.expression());
    }
    
    public override object? VisitNumericAddOpExpression(c2022v2Parser.NumericAddOpExpressionContext context)
    {
        Object? val1 = Visit(context.expression(0));
        Object? val2 = Visit(context.expression(1));
        string val3 = context.numericAddOp().GetText();
        if (val1 != null && val2 != null)
        {
            var type1 = val1.GetType();
            var type2 = val2.GetType();
            
            if (val1.GetType().FullName == "System.Int32")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (int)val1 + (double)val2;
                        case "-" :
                            return (int)val1 - (double)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (int)val1 + (int)val2;
                        case "-" :
                            return (int)val1 - (int)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (int)val1 + (char)val2;
                        case "-" :
                            return (int)val1 - (char)val2;
                        default: break;
                    }
                }
            }
            else if (val1.GetType().FullName == "System.Double")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (double)val1 + (double)val2;
                        case "-" :
                            return (double)val1 - (double)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (double)val1 + (int)val2;
                        case "-" :
                            return (double)val1 - (int)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (double)val1 + (char)val2;
                        case "-" :
                            return (double)val1 - (char)val2;
                        default: break;
                    }
                }
            }
            else if (val1.GetType().FullName == "System.Char")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (char)val1 + (double)val2;
                        case "-" :
                            return (char)val1 - (double)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (char)val1 + (int)val2;
                        case "-" :
                            return (char)val1 - (int)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (char)val1 + (char)val2;
                        case "-" :
                            return (char)val1 - (char)val2;
                        default: break;
                    }
                }
            }
            else
            {
                throw new Exception("Variables stated cannot be added or subtracted");
            }
        }
        
        return base.VisitNumericAddOpExpression(context);
    }

    public override object? VisitNumericMultiOpExpression(c2022v2Parser.NumericMultiOpExpressionContext context)
    {
        Object? val1 = Visit(context.expression(0));
        Object? val2 = Visit(context.expression(1));
        
        if (val1 != null && val2 != null)
        {
            var type1 = val1.GetType();
            var type2 = val2.GetType();
            
            if (val1.GetType().FullName == "System.Int32")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (int)val1 * (double)val2;
                        case "/" :
                            return (int)val1 / (double)val2;
                        case "%" :
                            return (int)val1 % (double)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (int)val1 * (int)val2;
                        case "/" :
                            return (int)val1 / (int)val2;
                        case "%" :
                            return (int)val1 % (int)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (int)val1 * (char)val2;
                        case "/" :
                            return (int)val1 / (char)val2;
                        case "%" :
                            return (int)val1 % (char)val2;
                        default: break;
                    }
                }
            }
            else if (val1.GetType().FullName == "System.Double")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (double)val1 * (double)val2;
                        case "/" :
                            return (double)val1 / (double)val2;
                        case "%" :
                            return (double)val1 % (double)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (double)val1 * (int)val2;
                        case "/" :
                            return (double)val1 / (int)val2;
                        case "%" :
                            return (double)val1 % (int)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (double)val1 * (char)val2;
                        case "/" :
                            return (double)val1 / (char)val2;
                        case "%" :
                            return (double)val1 % (char)val2;
                        default: break;
                    }
                }
            }
            else if (val1.GetType().FullName == "System.Char")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (char)val1 * (double)val2;
                        case "/" :
                            return (char)val1 / (double)val2;
                        case "%" :
                            return (char)val1 % (double)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (char)val1 * (int)val2;
                        case "/" :
                            return (char)val1 / (int)val2;
                        case "%" :
                            return (char)val1 % (int)val2;
                        default: break;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (context.numericMultiOp().GetText())
                    {
                        case "*" :
                            return (char)val1 * (char)val2;
                        case "/" :
                            return (char)val1 / (char)val2;
                        case "%" :
                            return (char)val1 % (char)val2;
                        default: break;
                    }
                }
            }
            else
            {
                throw new Exception("Variables stated cannot be added or subtracted");
            }
        }

        return null;
    }

    public override object? VisitUnaryOp(c2022v2Parser.UnaryOpContext context)
    {
        var value = Visit(context);
        return null;
    }
    public override object? VisitUnaryOpExpression(c2022v2Parser.UnaryOpExpressionContext context)
    {
        var value = Visit(context.IDENTIFIER()); // Sitas checkina jau del esamybes
        if (value != null)
        {
            var type = value.GetType();
            Console.WriteLine(type);
            if (type is Int32)
            {
               int  temp = (int)value;
                switch (context.unaryOp().GetText())
                {
                    case "++":
                        temp++;
                        Console.WriteLine(temp);
                        return temp;
                    case "--":
                        temp--;
                        return temp;
                    default:
                        return null;
                        ;
                }
            }
            else if (type is char)
            {
                char temp = (char)value;
                switch (context.unaryOp().GetText())
                {
                    case "++":
                        temp++;
                        return temp;
                    case "--":
                        temp--;
                        return temp;
                    default:
                        return null;
                        ;
                }
            }
            else if (type is Double)
            {
                double temp = (double)value;
                switch (context.unaryOp().GetText())
                {
                    case "++":
                        temp++;
                        return temp;
                    case "--":
                        temp--;
                        return temp;
                    default:
                        return null;
                        ;
                }
            }
            else
            {
                throw new Exception("pasitart su arnu");
            }
        }

        return base.VisitUnaryOpExpression(context);
    }

    public override object? VisitPrintCall(c2022v2Parser.PrintCallContext context)
    {
        if (Visit(context.expression()) is { } c)
        {
            string? text = c.ToString();
            Console.WriteLine(text);
        }
        return null;
}
}