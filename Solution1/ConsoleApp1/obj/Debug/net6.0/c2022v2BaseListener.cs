﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\KTUOneDrive\OneDrive - Kaunas University of Technology\4pusmetis\Programavimo kalbų teorija\Compiler\CompilerC2022V2\Solution1\ConsoleApp1\Content\c2022v2.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ConsoleApp1.Content {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="Ic2022v2Listener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class c2022v2BaseListener : Ic2022v2Listener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantExpression([NotNull] c2022v2Parser.ConstantExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantExpression([NotNull] c2022v2Parser.ConstantExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierExpression([NotNull] c2022v2Parser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierExpression([NotNull] c2022v2Parser.IdentifierExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>unaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryOpExpression([NotNull] c2022v2Parser.UnaryOpExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryOpExpression([NotNull] c2022v2Parser.UnaryOpExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCallExpression([NotNull] c2022v2Parser.FunctionCallExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCallExpression([NotNull] c2022v2Parser.FunctionCallExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesesExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesesExpression([NotNull] c2022v2Parser.ParenthesesExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesesExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesesExpression([NotNull] c2022v2Parser.ParenthesesExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanUnaryExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanUnaryExpression([NotNull] c2022v2Parser.BooleanUnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanUnaryExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanUnaryExpression([NotNull] c2022v2Parser.BooleanUnaryExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanBinaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanBinaryOpExpression([NotNull] c2022v2Parser.BooleanBinaryOpExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanBinaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanBinaryOpExpression([NotNull] c2022v2Parser.BooleanBinaryOpExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>numericMultiOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericMultiOpExpression([NotNull] c2022v2Parser.NumericMultiOpExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numericMultiOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericMultiOpExpression([NotNull] c2022v2Parser.NumericMultiOpExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>numericAddOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericAddOpExpression([NotNull] c2022v2Parser.NumericAddOpExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>numericAddOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericAddOpExpression([NotNull] c2022v2Parser.NumericAddOpExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanCompareExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanCompareExpression([NotNull] c2022v2Parser.BooleanCompareExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanCompareExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanCompareExpression([NotNull] c2022v2Parser.BooleanCompareExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] c2022v2Parser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] c2022v2Parser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] c2022v2Parser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] c2022v2Parser.LineContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] c2022v2Parser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] c2022v2Parser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.mathAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMathAssignment([NotNull] c2022v2Parser.MathAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.mathAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMathAssignment([NotNull] c2022v2Parser.MathAssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] c2022v2Parser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] c2022v2Parser.AssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.arrayAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayAssignment([NotNull] c2022v2Parser.ArrayAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.arrayAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayAssignment([NotNull] c2022v2Parser.ArrayAssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.unaryOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryOperation([NotNull] c2022v2Parser.UnaryOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.unaryOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryOperation([NotNull] c2022v2Parser.UnaryOperationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.funCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunCall([NotNull] c2022v2Parser.FunCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.funCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunCall([NotNull] c2022v2Parser.FunCallContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.bindCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBindCall([NotNull] c2022v2Parser.BindCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.bindCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBindCall([NotNull] c2022v2Parser.BindCallContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.printCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintCall([NotNull] c2022v2Parser.PrintCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.printCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintCall([NotNull] c2022v2Parser.PrintCallContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfBlock([NotNull] c2022v2Parser.IfBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.ifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfBlock([NotNull] c2022v2Parser.IfBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.elseifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseifBlock([NotNull] c2022v2Parser.ElseifBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.elseifBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseifBlock([NotNull] c2022v2Parser.ElseifBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseBlock([NotNull] c2022v2Parser.ElseBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.elseBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseBlock([NotNull] c2022v2Parser.ElseBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.forBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForBlock([NotNull] c2022v2Parser.ForBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.forBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForBlock([NotNull] c2022v2Parser.ForBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.whileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileBlock([NotNull] c2022v2Parser.WhileBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.whileBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileBlock([NotNull] c2022v2Parser.WhileBlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] c2022v2Parser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] c2022v2Parser.BlockContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] c2022v2Parser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] c2022v2Parser.ExpressionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.numericMultiAss"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericMultiAss([NotNull] c2022v2Parser.NumericMultiAssContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.numericMultiAss"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericMultiAss([NotNull] c2022v2Parser.NumericMultiAssContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.numericMultiOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericMultiOp([NotNull] c2022v2Parser.NumericMultiOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.numericMultiOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericMultiOp([NotNull] c2022v2Parser.NumericMultiOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.numericAddAss"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericAddAss([NotNull] c2022v2Parser.NumericAddAssContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.numericAddAss"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericAddAss([NotNull] c2022v2Parser.NumericAddAssContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.numericAddOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericAddOp([NotNull] c2022v2Parser.NumericAddOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.numericAddOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericAddOp([NotNull] c2022v2Parser.NumericAddOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.unaryOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryOp([NotNull] c2022v2Parser.UnaryOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.unaryOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryOp([NotNull] c2022v2Parser.UnaryOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.booleanBinaryOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanBinaryOp([NotNull] c2022v2Parser.BooleanBinaryOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.booleanBinaryOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanBinaryOp([NotNull] c2022v2Parser.BooleanBinaryOpContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.comp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp([NotNull] c2022v2Parser.CompContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.comp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp([NotNull] c2022v2Parser.CompContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] c2022v2Parser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] c2022v2Parser.ConstantContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace ConsoleApp1.Content
