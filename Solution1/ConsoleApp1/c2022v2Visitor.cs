using System.Collections;
using System.Reflection;
using ConsoleApp1.Content;

namespace ConsoleApp1;

public class C2022V2Visitor : c2022v2BaseVisitor<object?>
{
    private Dictionary<string, object?> Variables { get; } = new();
    private Dictionary<string, c2022v2Parser.FuncDeclarationContext> Funs { get; } = new();

    private int bindNumber = 1;

    struct bindStruct
    {
        public int id;
        public object? value;
    }

    struct arrayStruct
    {
        public string type;
        public object? value;
    }

    public override object? VisitFuncDeclaration(c2022v2Parser.FuncDeclarationContext context)
    {
        var funName = context.IDENTIFIER(0).GetText();
        var count = context.IDENTIFIER().Length;
        
        for (int i = 1; i < count; i++)
        {
            Variables[$"{funName}_{context.IDENTIFIER(i).GetText()}"] = null;
        }

        if (!Funs.ContainsKey(funName))
        {
            Funs[funName] = context;
        }
        else
        {
            throw new Exception($"Fun with {funName} identifier already exist");
        }
        
        return null;
    }

    public override object? VisitFunCall(c2022v2Parser.FunCallContext context)
    {
        var funName = context.IDENTIFIER(0).GetText();
        
        
        if (Funs.ContainsKey(funName))
        {
            var funContext = Funs[funName];

            if (funContext.IDENTIFIER().Length != context.IDENTIFIER().Length)
            {
                throw new Exception("Fun was called with not enough arguments");
            }

            var count = funContext.IDENTIFIER().Length;
            for (int i = 1; i < count; i++)
            {
                Variables[$"{funName}_{funContext.IDENTIFIER(i).GetText()}"] = Variables[context.IDENTIFIER(i).GetText()];
            }
            
            foreach (var line in funContext.line())
            {
                Visit(line);
            }
            
            for (int i = 1; i < count; i++)
            {
                Variables[context.IDENTIFIER(i).GetText()] = Variables[$"{funName}_{funContext.IDENTIFIER(i).GetText()}"];
            }
        }
        else
        {
            throw new Exception($"Fun with {funName} identifier does not exist");
        }
        
        return null;
    }

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
                        Console.WriteLine($"Binded {variableName}");
                        
                        bindStruct b = new bindStruct();
                        b.id = bindNumber;
                        b.value = Variables[variableNameString];

                        Variables[variableNameString] = b;
                    }
                    else
                        throw new Exception("Variable not found !!!");
                }
                bindNumber++;
                break;
            case "unbind" :
                foreach (var variableName in context.IDENTIFIER())
                {
                    string variableNameString = variableName.GetText();
                    if (Variables.ContainsKey(variableNameString))
                    {
                        Console.WriteLine($"Unbinded {variableName}");
                        var b = (bindStruct)Variables[variableNameString]!;
                        Variables[variableNameString] = b.value;
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
            if (val1.GetType().FullName == "ConsoleApp1.C2022V2Visitor+bindStruct")
            {
                bindStruct b = (bindStruct)val1;
                
                if (val2.GetType().FullName == "System.Int32")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            foreach (var i in Variables)
                            {
                                if (i.Value is bindStruct)
                                {
                                    if (i.Value != null)
                                    {
                                        bindStruct tempBind = (bindStruct)i.Value!;
                                        if (tempBind.id == b.id)
                                        {
                                            int tempTemp = (int)tempBind.value!;
                                            tempTemp+=(int)val2;
                                            tempBind.value = tempTemp;
                                            Variables[i.Key] = tempBind;
                                        }
                                    }
                                }
                            }
                            return Variables[context.expression(0).GetText()];
                        case "-" :
                            foreach (var i in Variables)
                            {
                                if (i.Value is bindStruct)
                                {
                                    if (i.Value != null)
                                    {
                                        bindStruct tempBind = (bindStruct)i.Value!;
                                        if (tempBind.id == b.id)
                                        {
                                            int tempTemp = (int)tempBind.value!;
                                            tempTemp-=(int)val2;
                                            tempBind.value = tempTemp;
                                            Variables[i.Key] = tempBind;
                                        }
                                    }
                                }
                            }
                            return Variables[context.expression(0).GetText()];
                    }
                }
                
                if (val2.GetType().FullName == "System.Double")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            foreach (var i in Variables)
                            {
                                if (i.Value is bindStruct)
                                {
                                    if (i.Value != null)
                                    {
                                        bindStruct tempBind = (bindStruct)i.Value!;
                                        if (tempBind.id == b.id)
                                        {
                                            double tempTemp = (double)tempBind.value!;
                                            tempTemp+=(double)val2;
                                            tempBind.value = tempTemp;
                                            Variables[i.Key] = tempBind;
                                        }
                                    }
                                }
                            }
                            return Variables[context.expression(0).GetText()];
                        case "-" :
                            foreach (var i in Variables)
                            {
                                if (i.Value is bindStruct)
                                {
                                    if (i.Value != null)
                                    {
                                        bindStruct tempBind = (bindStruct)i.Value!;
                                        if (tempBind.id == b.id)
                                        {
                                            double tempTemp = (double)tempBind.value!;
                                            tempTemp-=(double)val2;
                                            tempBind.value = tempTemp;
                                            Variables[i.Key] = tempBind;
                                        }
                                    }
                                }
                            }
                            return Variables[context.expression(0).GetText()];
                    }
                }
                
            }
            
            if (val2.GetType().FullName == "ConsoleApp1.C2022V2Visitor+bindStruct")
            {
                bindStruct b = (bindStruct)val2;
                
                if (val1.GetType().FullName == "System.Int32")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            foreach (var i in Variables)
                            {
                                if (i.Value is bindStruct)
                                {
                                    if (i.Value != null)
                                    {
                                        bindStruct tempBind = (bindStruct)i.Value!;
                                        if (tempBind.id == b.id)
                                        {
                                            int tempTemp = (int)tempBind.value!;
                                            tempTemp+=(int)val1;
                                            tempBind.value = tempTemp;
                                            Variables[i.Key] = tempBind;
                                        }
                                    }
                                }
                            }
                            return Variables[context.expression(1).GetText()];
                        case "-" :
                            foreach (var i in Variables)
                            {
                                if (i.Value is bindStruct)
                                {
                                    if (i.Value != null)
                                    {
                                        bindStruct tempBind = (bindStruct)i.Value!;
                                        if (tempBind.id == b.id)
                                        {
                                            int tempTemp = (int)tempBind.value!;
                                            tempTemp-=(int)val1;
                                            tempBind.value = tempTemp;
                                            Variables[i.Key] = tempBind;
                                        }
                                    }
                                }
                            }
                            return Variables[context.expression(1).GetText()];
                    }
                }
                
                if (val1.GetType().FullName == "System.Double")
                {
                    switch (context.numericAddOp().GetText())
                    {
                        case "+" :
                            foreach (var i in Variables)
                            {
                                if (i.Value is bindStruct)
                                {
                                    if (i.Value != null)
                                    {
                                        bindStruct tempBind = (bindStruct)i.Value!;
                                        if (tempBind.id == b.id)
                                        {
                                            double tempTemp = (double)tempBind.value!;
                                            tempTemp += (double)val1;
                                            tempBind.value = tempTemp;
                                            Variables[i.Key] = tempBind;
                                        }
                                    }
                                }
                            }
                            return Variables[context.expression(1).GetText()];
                        case "-" :
                            foreach (var i in Variables)
                            {
                                if (i.Value is bindStruct)
                                {
                                    if (i.Value != null)
                                    {
                                        bindStruct tempBind = (bindStruct)i.Value!;
                                        if (tempBind.id == b.id)
                                        {
                                            double tempTemp = (double)tempBind.value!;
                                            tempTemp-=(double)val1;
                                            tempBind.value = tempTemp;
                                            Variables[i.Key] = tempBind;
                                        }
                                    }
                                }
                            }
                            return Variables[context.expression(1).GetText()];
                    }
                }
                
            }
            
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
            if (val1.GetType().FullName == "ConsoleApp1.C2022V2Visitor+bindStruct")
            {
                bindStruct b = (bindStruct)val1;

                if (b.value!.GetType().FullName == "System.Int32")
                {
                    if (val2.GetType().FullName == "System.Int32")
                    {
                        switch (context.numericMultiOp().GetText())
                        {
                            case "*" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp*=(int)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "/" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp/=(int)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "%" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp%=(int)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                        }
                    }
                    
                    if (val2.GetType().FullName == "System.Double")
                    {
                        switch (context.numericMultiOp().GetText())
                        {
                            case "*" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp*=(double)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "/" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp/=(double)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "%" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp%=(double)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                        }
                    }
                }

                if (b.value!.GetType().FullName == "System.Double")
                {
                    if (val2.GetType().FullName == "System.Int32")
                    {
                        switch (context.numericMultiOp().GetText())
                        {
                            case "*" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp*=(int)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "/" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp/=(int)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "%" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp%=(int)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                        }
                    }
                
                    if (val2.GetType().FullName == "System.Double")
                    {
                        switch (context.numericMultiOp().GetText())
                        {
                            case "*" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp*=(double)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "/" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp/=(double)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "%" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp%=(double)val2;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                        }
                    }
                }

            }
            
            if (val2.GetType().FullName == "ConsoleApp1.C2022V2Visitor+bindStruct")
            {
                bindStruct b = (bindStruct)val2;
                
                if (b.value!.GetType().FullName == "System.Int32")
                {
                    if (val1.GetType().FullName == "System.Int32")
                    {
                        switch (context.numericMultiOp().GetText())
                        {
                            case "*" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp*=(int)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "/" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp/=(int)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "%" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp%=(int)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                        }
                    }
                    
                    if (val1.GetType().FullName == "System.Double")
                    {
                        switch (context.numericMultiOp().GetText())
                        {
                            case "*" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp*=(double)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "/" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp/=(double)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                            case "%" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp%=(double)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(0).GetText()];
                        }
                    }
                }

                if (b.value!.GetType().FullName == "System.Double")
                {
                    if (val1.GetType().FullName == "System.Int32")
                    {
                        switch (context.numericMultiOp().GetText())
                        {
                            case "*" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp*=(int)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(1).GetText()];
                            case "/" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp/=(int)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(1).GetText()];
                            case "%" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp%=(int)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(1).GetText()];
                        }
                    }
                
                    if (val1.GetType().FullName == "System.Double")
                    {
                        switch (context.numericMultiOp().GetText())
                        {
                            case "*" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp*=(double)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(1).GetText()];
                            case "/" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp/=(double)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(1).GetText()];
                            case "%" :
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp%=(double)val1;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return Variables[context.expression(1).GetText()];
                        }
                    }
                }
                
            }
            
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
                throw new Exception("Variables stated cannot be multiplied or divided");
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
                if (value.GetType().FullName == "ConsoleApp1.C2022V2Visitor+bindStruct")
                {
                    bindStruct b = (bindStruct)value;
                    if (b.value!.GetType().FullName == "System.Int32")
                    {
                        switch (context.unaryOp().GetText())
                        {
                            case "++":
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp++;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return null;
                            case "--":
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp--;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return null;
                            default:
                                return null;
                        }
                    }
                    
                    if (b.value!.GetType().FullName == "System.Double")
                    {
                        switch (context.unaryOp().GetText())
                        {
                            case "++":
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp++;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return null;
                            case "--":
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp--;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return null;
                            default:
                                return null;
                        }
                    }
                }
                
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
            if (value.GetType().FullName == "ConsoleApp1.C2022V2Visitor+bindStruct")
                {
                    bindStruct b = (bindStruct)value;
                    if (b.value!.GetType().FullName == "System.Int32")
                    {
                        switch (context.unaryOp().GetText())
                        {
                            case "++":
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp++;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return null;
                            case "--":
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                int tempTemp = (int)tempBind.value!;
                                                tempTemp--;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return null;
                            default:
                                return null;
                        }
                    }
                    
                    if (b.value!.GetType().FullName == "System.Double")
                    {
                        switch (context.unaryOp().GetText())
                        {
                            case "++":
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp++;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return null;
                            case "--":
                                foreach (var i in Variables)
                                {
                                    if (i.Value is bindStruct)
                                    {
                                        if (i.Value != null)
                                        {
                                            bindStruct tempBind = (bindStruct)i.Value!;
                                            if (tempBind.id == b.id)
                                            {
                                                double tempTemp = (double)tempBind.value!;
                                                tempTemp--;
                                                tempBind.value = tempTemp;
                                                Variables[i.Key] = tempBind;
                                            }
                                        }
                                    }
                                }
                                return null;
                            default:
                                return null;
                        }
                    }
                }
            
            if (value.GetType().FullName == "System.Int32")
            {
                int temp = (int)value;
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
            if (c is bindStruct)
            {
                bindStruct b = (bindStruct)c;
                string? text = b.value!.ToString();
                Console.WriteLine(text);
            }
            else
            {
                string? text = c.ToString();
                Console.WriteLine(text);
            }
            
            
        }
        else
        {
            Console.WriteLine("null");
        }
        return null;
    }

    public override object? VisitArrayAssignment(c2022v2Parser.ArrayAssignmentContext context)
    {
        if (context.TYPE() != null)
        {
            var key = context.IDENTIFIER().GetText();
            var visitedExpression = Visit(context.expression(0));
            if (visitedExpression != null)
            {
                if (visitedExpression.GetType().ToString() == "System.Int32")
                {
                    int integer = (int)visitedExpression;
                    if (!Variables.ContainsKey(key))
                    {
                        arrayStruct b = new arrayStruct();
                        b.type = context.TYPE().GetText();
                        b.value = new object[integer];
                        Variables[key] = b;
                        
                    }
                    else
                    {
                        throw new Exception("Can't initialize an array that has been previuosly declared");
                    }
                }
                else
                {
                    throw new Exception("Expression must be an INTEGER");
                }
            }
            else
            {
                throw new Exception("Visited expression doesn't exist");
            }
        }
        else
        {
            var key = context.IDENTIFIER().GetText();
            var visitFirstExpression = Visit(context.expression(0));
            var visitSecondExpression = Visit(context.expression(1));
            if (Variables.ContainsKey(key))
            {
                var arrayStruct = Variables[key];
                if (arrayStruct != null)
                {
                    arrayStruct castedArrayStruct = (arrayStruct)arrayStruct;
                    if (visitFirstExpression != null && visitSecondExpression != null)
                    {
                        if (visitFirstExpression.GetType().ToString() == "System.Int32")
                        {
                            var arr = castedArrayStruct.value as IEnumerable;
                            int where = (int)visitFirstExpression;
                            List<object> temp = new List<object>();
                            
                            //Susidedam i temporary array
                            if (arr != null)
                            {
                                foreach (var variable in arr)
                                {
                                    temp.Add(variable);
                                }
                            }

                            if (where >= temp.Count)
                            {
                                throw new IndexOutOfRangeException();
                            }

                            if (castedArrayStruct.type == "int" &&
                                visitSecondExpression.GetType().ToString() == "System.Int32")
                            {
                                temp[where] = (int)visitSecondExpression;
                                castedArrayStruct.value = temp.ToArray();
                                Variables[key] = castedArrayStruct;
                                return temp[where];
                            }
                            else if (castedArrayStruct.type == "double" &&
                                visitSecondExpression.GetType().ToString() == "System.Double")
                            {
                                temp[where] = (double)visitSecondExpression;
                                castedArrayStruct.value = temp.ToArray();
                                Variables[key] = castedArrayStruct;
                                return temp[where];
                            }
                            else if (castedArrayStruct.type == "char" &&
                                visitSecondExpression.GetType().ToString() == "System.Char")
                            {
                                temp[where] = (char)visitSecondExpression;
                                castedArrayStruct.value = temp.ToArray();
                                Variables[key] = castedArrayStruct;
                                return temp[where];
                            }
                            else
                            {
                                throw new Exception(String.Format("The specified variable is not of the array type : \" {0} \" type : {1} needs to be an  : \"{2}\"",visitSecondExpression,visitSecondExpression.GetType(),castedArrayStruct.type));
                            }
                        }
                        else
                        {
                            throw new Exception("Index must be an integer or an expression which will result in an Integer");
                        }
                    }
                    else
                    {
                        throw new Exception("One of the given expressions is null");
                    }
                    
                }
                else
                {
                    throw new Exception("The structure at the given index is null and can't be reached");
                }
            }
            else
            {
                throw new Exception("The specified array/key doesn't exist");
            }
        }

        return null;
    }

    public override object? VisitArrayExp(c2022v2Parser.ArrayExpContext context)
    {
        var key = context.IDENTIFIER().GetText();
        var arrayStruct = Variables[key];
        var visitExpression = Visit(context.expression());
        if (visitExpression != null)
        {
            if (arrayStruct != null)
            {
                var arrayStructCast = (arrayStruct)arrayStruct;
                var arr = arrayStructCast.value as IEnumerable;
                var integer = (int)visitExpression;

                List<object> temp = new List<object>();

                //Susidedam i temporary array
                if (arr != null)
                {
                    foreach (var variable in arr)
                    {
                        temp.Add(variable);
                    }
                }

                if (integer < temp.Count)
                {
                    return temp[integer];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else return null;
        }
        else
        {
            throw new Exception("Index out of range");
        }

        return null;
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
                if (val1.GetType().FullName == "ConsoleApp1.C2022V2Visitor+bindStruct")
                {
                    bindStruct b = (bindStruct)val1;
                    if (b.value!.GetType().FullName == "System.Int32")
                    {
                        if (val2.GetType().FullName == "System.Int32")
                        {
                            int castedVal1 = (int)b.value!;
                            int castedVal2 = (int)val2;

                            switch (context.numericAss().GetText())
                            {
                                case "+=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    int tempTemp = (int)tempBind.value!;
                                                    tempTemp += (int)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                                case "-=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    int tempTemp = (int)tempBind.value!;
                                                    tempTemp -= (int)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                                case "*=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    int tempTemp = (int)tempBind.value!;
                                                    tempTemp *= (int)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                                case "/=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    int tempTemp = (int)tempBind.value!;
                                                    tempTemp /= (int)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                                case "%=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    int tempTemp = (int)tempBind.value!;
                                                    tempTemp %= (int)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                            }
                        }
                        else
                        {
                            throw new Exception(
                                "Mathematical assign operations can only be between two numbers types of the same type(int32)");
                        }
                    }
                    else if (b.value!.GetType().FullName == "System.Double")
                    {
                        if (val2.GetType().FullName == "System.Double")
                        {
                            double castedVal1 = (double)b.value!;
                            double castedVal2 = (double)val2;

                            switch (context.numericAss().GetText())
                            {
                                case "+=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    double tempTemp = (double)tempBind.value!;
                                                    tempTemp += (double)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                                case "-=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    double tempTemp = (double)tempBind.value!;
                                                    tempTemp -= (double)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                                case "*=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    double tempTemp = (double)tempBind.value!;
                                                    tempTemp *= (double)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                                case "/=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    double tempTemp = (double)tempBind.value!;
                                                    tempTemp /= (double)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                                case "%=":
                                    foreach (var i in Variables)
                                    {
                                        if (i.Value is bindStruct)
                                        {
                                            if (i.Value != null)
                                            {
                                                bindStruct tempBind = (bindStruct)i.Value!;
                                                if (tempBind.id == b.id)
                                                {
                                                    double tempTemp = (double)tempBind.value!;
                                                    tempTemp %= (double)val2;
                                                    tempBind.value = tempTemp;
                                                    Variables[i.Key] = tempBind;
                                                }
                                            }
                                        }
                                    }

                                    return Variables[context.IDENTIFIER().GetText()];
                            }
                        }
                        else
                        {
                            throw new Exception(
                                "Mathematical assign operations can only be between two numbers types of the same type");
                        }
                    }
                    else
                    {
                        throw new Exception(
                            "Bind does not support this type");
                    }

                    
                }
                
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
                        throw new Exception(
                            "Mathematical assign operations can only be between two numbers types of the same type(int32)");
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
                        throw new Exception(
                            "Mathematical assign operations can only be between two numbers types of the same type(double)");
                    }
                }
                else
                {
                    throw new Exception(
                        "Mathematical assign operations can only be between two numbers types of the same type");
                }

                throw new Exception("One of the assigned operators is null");
            }

            throw new Exception("Identifier doesn't exist");
        }

        return null;
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