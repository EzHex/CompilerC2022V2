using System.Collections;
using ConsoleApp1.Content;

namespace ConsoleApp1;

public class C2022V2Visitor : c2022v2BaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new();

    public override object? VisitBindCall(c2022v2Parser.BindCallContext context)
    {
        Console.WriteLine(context.BIND().GetText());
        switch (context.BIND().GetText())
        {
            case "bind" :
                foreach (var variableName in context.IDENTIFIER())
                {
                    string variableNameString = variableName.GetText();
                    if (Variables.ContainsKey(variableNameString))
                    {
                        Console.WriteLine("Binded {0}",variableName);
                    }
                    else
                        throw new Exception("Variable not found !!!");
                }

                break;
            case "unbind" :
                foreach (var variableName in context.IDENTIFIER())
                {
                    string variableNameString = variableName.GetText();
                    if (Variables.ContainsKey(variableNameString))
                    {
                        Console.WriteLine("Unbinded {0}",variableName);
                    }
                    else
                        throw new Exception("Variable not found !!!");
                }

                break;
        }
        
        return null;
    }

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
        if (constant is { })
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

            throw new Exception("Identifier not found");
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
        if (val1 != null && val2 != null)
        {
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
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (char)((char)val1 + (int)val2);
                        case "-" :
                            return (char)((char)val1 - (int)val2);
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            return (char)((char)val1 + (char)val2);
                        case "-" :
                            return (char)((char)val1 - (char)val2);
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

    public override object? VisitUnaryOperation(c2022v2Parser.UnaryOperationContext context)
    {
        var identifier = context.IDENTIFIER().GetText();
        if (Variables.ContainsKey(identifier))
        {
            var value = Variables[identifier];
            if (value != null)
            {
                if (value.GetType().FullName == "System.Double")
                {
                    switch (context.unaryOp().GetText())
                    {
                        case "++":
                            double temp = (double)value;
                            temp++;
                            Variables[identifier] = temp;
                            return temp;
                        case "--":
                            temp = (double)value;
                            temp--;
                            Variables[identifier] = temp;
                            return temp;
                    }
                }

                if (value.GetType().FullName == "System.Int32")
                {
                    switch (context.unaryOp().GetText())
                    {
                        case "++":
                            int temp = (int)value;
                            temp++;
                            Variables[identifier] = temp;
                            return temp;
                        case "--":
                            temp = (int)value;
                            temp--;
                            Variables[identifier] = temp;
                            return temp;
                    }
                }

                if (value.GetType().FullName == "System.Char")
                {
                    switch (context.unaryOp().GetText())
                    {
                        case "++":
                            char temp = (char)value;
                            temp++;
                            Variables[identifier] = temp;
                            return temp;
                        case "--":
                            temp = (char)value;
                            temp--;
                            Variables[identifier] = temp;
                            return temp;
                    }
                }
            }

            return value;
        }
        return base.VisitUnaryOperation(context);
    }

    public override object? VisitUnaryOpExpression(c2022v2Parser.UnaryOpExpressionContext context)
    {
        var identifier = context.IDENTIFIER().GetText();
        var value = Variables[identifier];
        if (value != null)
        {
            if (value.GetType().FullName == "System.Int32")
            {
               int  temp = (int)value;
                switch (context.unaryOp().GetText())
                {
                    case "++":
                        temp++;
                        Variables[identifier] = temp;
                        return temp;
                    case "--":
                        temp--;
                        Variables[identifier] = temp;
                        return temp;
                    default:
                        return null;
                }
            }
            if (value.GetType().FullName == "System.Char")
            {
                char temp = (char)value;
                switch (context.unaryOp().GetText())
                {
                    case "++":
                        temp++;
                        Variables[identifier] = temp;
                        return temp;
                    case "--":
                        temp--;
                        Variables[identifier] = temp;
                        return temp;
                    default:
                        return null;
                }
            }
            if (value.GetType().FullName == "System.Double")
            {
                double temp = (double)value;
                switch (context.unaryOp().GetText())
                {
                    case "++":
                        temp++;
                        Variables[identifier] = temp;
                        return temp;
                    case "--":
                        temp--;
                        Variables[identifier] = temp;
                        return temp;
                    default:
                        return null;
                }
            }
            else
            {
                throw new Exception("Can't perform unary on selected type");
            }
        }

        return base.VisitUnaryOpExpression(context);
    }

    public override object? VisitBooleanCompareExpression(c2022v2Parser.BooleanCompareExpressionContext context)
    {
        var val1 = Visit(context.expression(0));
        var val2 = Visit(context.expression(1));
        var comparator = context.comp().GetText();
        if (val1 != null && val2 != null)
        {
            if (val1.GetType().FullName == "System.Int32")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (int)val1 > (double)val2;
                        case "<":
                            return (int)val1 < (double)val2;
                        case "==":
                            return (int)val1 == (double)val2;
                        case "!=":
                            return (int)val1 != (double)val2;
                        case "<=":
                            return (int)val1 <= (double)val2;
                        case ">=":
                            return (int)val1 >= (double)val2;
                        default:
                            return null;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (int)val1 > (int)val2;
                        case "<":
                            return (int)val1 < (int)val2;
                        case "==":
                            return (int)val1 == (int)val2;
                        case "!=":
                            return (int)val1 != (int)val2;
                        case "<=":
                            return (int)val1 <= (int)val2;
                        case ">=":
                            return (int)val1 >= (int)val2;
                        default:
                            return null;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (int)val1 > (char)val2;
                        case "<":
                            return (int)val1 < (char)val2;
                        case "==":
                            return (int)val1 == (char)val2;
                        case "!=":
                            return (int)val1 != (char)val2;
                        case "<=":
                            return (int)val1 <= (char)val2;
                        case ">=":
                            return (int)val1 >= (char)val2;
                        default:
                            return null;
                    }
                }

                if (val2.GetType().FullName == "System.Boolean")
                {
                    throw new Exception("Cant compare of type : Int32 and Boolean");
                }
            }
            if (val1.GetType().FullName == "System.Double")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (double)val1 > (double)val2;
                        case "<":
                            return (double)val1 < (double)val2;
                        case "==":
                            return (double)val1 == (double)val2;
                        case "!=":
                            return (double)val1 != (double)val2;
                        case "<=":
                            return (double)val1 <= (double)val2;
                        case ">=":
                            return (double)val1 >= (double)val2;
                        default:
                            return null;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (double)val1 > (int)val2;
                        case "<":
                            return (double)val1 < (int)val2;
                        case "==":
                            return (double)val1 == (int)val2;
                        case "!=":
                            return (double)val1 != (int)val2;
                        case "<=":
                            return (double)val1 <= (int)val2;
                        case ">=":
                            return (double)val1 >= (int)val2;
                        default:
                            return null;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (double)val1 > (char)val2;
                        case "<":
                            return (double)val1 < (char)val2;
                        case "==":
                            return (double)val1 == (char)val2;
                        case "!=":
                            return (double)val1 != (char)val2;
                        case "<=":
                            return (double)val1 <= (char)val2;
                        case ">=":
                            return (double)val1 >= (char)val2;
                        default:
                            return null;
                    }
                }

                if (val2.GetType().FullName == "System.Boolean")
                {
                    throw new Exception("Cant compare of type : Double and Boolean");
                }
            }
            if (val1.GetType().FullName == "System.Char")
            {
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (char)val1 > (double)val2;
                        case "<":
                            return (char)val1 < (double)val2;
                        case "==":
                            return (char)val1 == (double)val2;
                        case "!=":
                            return (char)val1 != (double)val2;
                        case "<=":
                            return (char)val1 <= (double)val2;
                        case ">=":
                            return (char)val1 >= (double)val2;
                        default:
                            return null;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (char)val1 > (int)val2;
                        case "<":
                            return (char)val1 < (int)val2;
                        case "==":
                            return (char)val1 == (int)val2;
                        case "!=":
                            return (char)val1 != (int)val2;
                        case "<=":
                            return (char)val1 <= (int)val2;
                        case ">=":
                            return (char)val1 >= (int)val2;
                        default:
                            return null;
                    }
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    switch (comparator)
                    {
                        case ">":
                            return (char)val1 > (char)val2;
                        case "<":
                            return (char)val1 < (char)val2;
                        case "==":
                            return (char)val1 == (char)val2;
                        case "!=":
                            return (char)val1 != (char)val2;
                        case "<=":
                            return (char)val1 <= (char)val2;
                        case ">=":
                            return (char)val1 >= (char)val2;
                        default:
                            return null;
                    }
                }

                if (val2.GetType().FullName == "System.Boolean")
                {
                    throw new Exception("Cant compare of type : char and Boolean");
                }
            }
            if (val1.GetType().FullName == "System.Boolean")
            {
                if (val2.GetType().FullName == "System.Boolean")
                {
                    switch (comparator)
                    {
                        case "==":
                            return (bool)val1 == (bool)val2;
                        case "!=":
                            return (bool)val1 != (bool)val2;
                        default:
                            return null;
                    }
                }
                if (val2.GetType().FullName == "System.Int32")
                {
                    throw new Exception("Cant compare of type : Boolean and Int32");
                }
                if (val2.GetType().FullName == "System.Char")
                {
                    throw new Exception("Cant compare of type : Boolean and Char");
                }

                if (val2.GetType().FullName == "System.Double")
                {
                    throw new Exception("Cant compare of type : Boolean and Double");
                }
            }
        }
        return true;
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

    public override object? VisitArrayAssignment(c2022v2Parser.ArrayAssignmentContext context)
    {
        var key = context.IDENTIFIER().GetText();
        var integer = int.Parse(context.INTEGER().GetText());
        
        if (!Variables.ContainsKey(key))
        {
            Variables[key] = new object[integer];
        }
        else
        {
            var value = Variables[key];
            var arr = value as IEnumerable;

            List<object> temp = new List<object>();
            
            if (arr != null)
            {
                foreach (var variable in arr)
                {
                    temp.Add(variable);
                }
            }

            var exp = Visit(context.expression());
            if ( exp != null)
            {
                temp[integer] = exp;

                Variables[key] = temp.ToArray();
                
                return null;
            }

            var toReturn = temp[integer];
            Console.WriteLine(toReturn.ToString());
            return integer < temp.Count ? temp[integer].ToString() : null;
        }

        return null;
    }

    public override object? VisitArrayExp(c2022v2Parser.ArrayExpContext context)
    {
        var key = context.IDENTIFIER().GetText();
        var arr = Variables[key] as IEnumerable;
        var integer = int.Parse(context.INTEGER().GetText());
        
        List<object> temp = new List<object>();
            
        if (arr != null)
        {
            foreach (var variable in arr)
            {
                temp.Add(variable);
            }
        }

        if (integer < temp.Count)
        {
            Console.WriteLine(temp[integer]);
            return null;
        }

        throw new Exception("Index out of range");
    }
    public override object? VisitIfBlock(c2022v2Parser.IfBlockContext context)
    {
        var expressResult = Visit(context.expression());
        if (expressResult != null)
        {
            if ((bool)expressResult)
            {
                Visit(context.block());
            }
            else
            {
                foreach (var elsif in context.elseifBlock())
                {
                    var elsifExpressionResult = Visit(elsif.expression());
                    if (elsifExpressionResult != null)
                    {
                        if ((bool)elsifExpressionResult)
                        {
                            Visit(elsif.block());
                            return null;
                        }
                    }
                }
                if (context.elseBlock() is { })
                {
                    Visit(context.elseBlock().block());
                }
            }
        }

        return null;
    }
    
    public override object? VisitWhileBlock(c2022v2Parser.WhileBlockContext context)
    {
        var expressionVisitResult = Visit(context.expression());
        if (expressionVisitResult != null)
        {
            bool express = (bool)expressionVisitResult;
            while (express)
            {
                Visit(context.block());
                expressionVisitResult = Visit(context.expression());
                if (expressionVisitResult != null)
                {
                    express = (bool)expressionVisitResult;
                }
            }
        }
        return null;
    }

    public override object? VisitMathAssignment(c2022v2Parser.MathAssignmentContext context)
    {
        var varName = context.IDENTIFIER().GetText();
        if (Variables.ContainsKey(varName))
        {
            var val1 = Variables[varName];
            var val2 = Visit(context.expression());
            if (val1 != null && val2 != null)
            {
                if (val1.GetType().FullName == "System.Int32")
                {
                    if (val2.GetType().FullName == "System.Int32")
                    {
                        int castedVal = (int)val1;
                        int castedVal2 = (int)val2;
                        switch (context.numericAss().GetText())
                        {
                            case "+=":
                                castedVal += castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                            case "-=":
                                castedVal -= castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                            case "*=":
                                castedVal *= castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                            case "/=":
                                castedVal /= castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                            case "%=":
                                castedVal %= castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                        }
                    }
                    else
                    {
                        throw new Exception("Mathematical assign operations can only be between two numbers types of the same type(int32)");
                    }
                }
                else if (val1.GetType().FullName == "System.Double")
                {
                    if (val2.GetType().FullName == "System.Double")
                    {
                        double castedVal = (double)val1;
                        double castedVal2 = (double)val2;
                        switch (context.numericAss().GetText())
                        {
                            case "+=":
                                castedVal += castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                            case "-=":
                                castedVal -= castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                            case "*=":
                                castedVal *= castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                            case "/=":
                                castedVal /= castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                            case "%=":
                                castedVal %= castedVal2;
                                Variables[varName] = castedVal;
                                return castedVal;
                        }
                    }
                    else
                    {
                        throw new Exception("Mathematical assign operations can only be between two numbers types of the same type(double)");
                    }
                }
                else
                {
                    throw new Exception("Mathematical assign operations can only be between two numbers types of the same type");
                }
            }

            throw new Exception("One of the assigned operators is null");
        }

        throw new Exception("Identifier doesn't exist");
    }

    public override object? VisitForBlock(c2022v2Parser.ForBlockContext context)
    {
        var initializeAssignmentResult = Visit(context.assignment());
        if (initializeAssignmentResult != null)
        {
            var initializeBooleanExpressionResult = Visit(context.expression(0));
            if (initializeBooleanExpressionResult != null)
            {
                bool expressionResult = (bool)initializeBooleanExpressionResult;
                while (expressionResult)
                {
                    Visit(context.block());
                    Visit(context.expression(1));
                    initializeBooleanExpressionResult = Visit(context.expression(0));
                    if (initializeBooleanExpressionResult != null)
                        expressionResult = (bool)initializeBooleanExpressionResult;
                }
                
            }
        }

        return null;
    }
}