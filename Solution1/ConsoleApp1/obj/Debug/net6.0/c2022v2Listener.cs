﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\modes\OneDrive\Stalinis kompiuteris\Compulerv2\CompilerC2022V2\Solution1\ConsoleApp1\Content\c2022v2.g4 by ANTLR 4.6.6

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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="c2022v2Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface Ic2022v2Listener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] c2022v2Parser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] c2022v2Parser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] c2022v2Parser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] c2022v2Parser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>unaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryOpExpression([NotNull] c2022v2Parser.UnaryOpExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryOpExpression([NotNull] c2022v2Parser.UnaryOpExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>arrayExp</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayExp([NotNull] c2022v2Parser.ArrayExpContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>arrayExp</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayExp([NotNull] c2022v2Parser.ArrayExpContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] c2022v2Parser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] c2022v2Parser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesesExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesesExpression([NotNull] c2022v2Parser.ParenthesesExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesesExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesesExpression([NotNull] c2022v2Parser.ParenthesesExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanUnaryExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanUnaryExpression([NotNull] c2022v2Parser.BooleanUnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanUnaryExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanUnaryExpression([NotNull] c2022v2Parser.BooleanUnaryExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanBinaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanBinaryOpExpression([NotNull] c2022v2Parser.BooleanBinaryOpExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanBinaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanBinaryOpExpression([NotNull] c2022v2Parser.BooleanBinaryOpExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>numericMultiOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericMultiOpExpression([NotNull] c2022v2Parser.NumericMultiOpExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numericMultiOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericMultiOpExpression([NotNull] c2022v2Parser.NumericMultiOpExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>numericAddOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericAddOpExpression([NotNull] c2022v2Parser.NumericAddOpExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>numericAddOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericAddOpExpression([NotNull] c2022v2Parser.NumericAddOpExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanCompareExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanCompareExpression([NotNull] c2022v2Parser.BooleanCompareExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanCompareExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanCompareExpression([NotNull] c2022v2Parser.BooleanCompareExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] c2022v2Parser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] c2022v2Parser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] c2022v2Parser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] c2022v2Parser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] c2022v2Parser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] c2022v2Parser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.mathAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathAssignment([NotNull] c2022v2Parser.MathAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.mathAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathAssignment([NotNull] c2022v2Parser.MathAssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] c2022v2Parser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] c2022v2Parser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.arrayAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayAssignment([NotNull] c2022v2Parser.ArrayAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.arrayAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayAssignment([NotNull] c2022v2Parser.ArrayAssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.unaryOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryOperation([NotNull] c2022v2Parser.UnaryOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.unaryOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryOperation([NotNull] c2022v2Parser.UnaryOperationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.funCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunCall([NotNull] c2022v2Parser.FunCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.funCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunCall([NotNull] c2022v2Parser.FunCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.bindCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBindCall([NotNull] c2022v2Parser.BindCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.bindCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBindCall([NotNull] c2022v2Parser.BindCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.printCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintCall([NotNull] c2022v2Parser.PrintCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.printCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintCall([NotNull] c2022v2Parser.PrintCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] c2022v2Parser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] c2022v2Parser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.elseifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseifBlock([NotNull] c2022v2Parser.ElseifBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.elseifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseifBlock([NotNull] c2022v2Parser.ElseifBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseBlock([NotNull] c2022v2Parser.ElseBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseBlock([NotNull] c2022v2Parser.ElseBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.forBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForBlock([NotNull] c2022v2Parser.ForBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.forBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForBlock([NotNull] c2022v2Parser.ForBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] c2022v2Parser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] c2022v2Parser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] c2022v2Parser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] c2022v2Parser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] c2022v2Parser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] c2022v2Parser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.numericAss"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericAss([NotNull] c2022v2Parser.NumericAssContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.numericAss"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericAss([NotNull] c2022v2Parser.NumericAssContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.numericMultiOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericMultiOp([NotNull] c2022v2Parser.NumericMultiOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.numericMultiOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericMultiOp([NotNull] c2022v2Parser.NumericMultiOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.numericAddOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericAddOp([NotNull] c2022v2Parser.NumericAddOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.numericAddOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericAddOp([NotNull] c2022v2Parser.NumericAddOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.unaryOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryOp([NotNull] c2022v2Parser.UnaryOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.unaryOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryOp([NotNull] c2022v2Parser.UnaryOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.booleanBinaryOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanBinaryOp([NotNull] c2022v2Parser.BooleanBinaryOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.booleanBinaryOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanBinaryOp([NotNull] c2022v2Parser.BooleanBinaryOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.comp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComp([NotNull] c2022v2Parser.CompContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.comp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComp([NotNull] c2022v2Parser.CompContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="c2022v2Parser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] c2022v2Parser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="c2022v2Parser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] c2022v2Parser.ConstantContext context);
}
} // namespace ConsoleApp1.Content
