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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="c2022v2Parser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface Ic2022v2Visitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpression([NotNull] c2022v2Parser.ConstantExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] c2022v2Parser.IdentifierExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>unaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryOpExpression([NotNull] c2022v2Parser.UnaryOpExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>arrayExp</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayExp([NotNull] c2022v2Parser.ArrayExpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallExpression([NotNull] c2022v2Parser.FunctionCallExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesesExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesesExpression([NotNull] c2022v2Parser.ParenthesesExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>booleanUnaryExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanUnaryExpression([NotNull] c2022v2Parser.BooleanUnaryExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>booleanBinaryOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanBinaryOpExpression([NotNull] c2022v2Parser.BooleanBinaryOpExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>numericMultiOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericMultiOpExpression([NotNull] c2022v2Parser.NumericMultiOpExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>numericAddOpExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericAddOpExpression([NotNull] c2022v2Parser.NumericAddOpExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>booleanCompareExpression</c>
	/// labeled alternative in <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanCompareExpression([NotNull] c2022v2Parser.BooleanCompareExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] c2022v2Parser.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] c2022v2Parser.LineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] c2022v2Parser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.mathAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathAssignment([NotNull] c2022v2Parser.MathAssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] c2022v2Parser.AssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.arrayAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayAssignment([NotNull] c2022v2Parser.ArrayAssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.unaryOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryOperation([NotNull] c2022v2Parser.UnaryOperationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.funCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunCall([NotNull] c2022v2Parser.FunCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.bindCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBindCall([NotNull] c2022v2Parser.BindCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.printCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintCall([NotNull] c2022v2Parser.PrintCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] c2022v2Parser.IfBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.elseifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseifBlock([NotNull] c2022v2Parser.ElseifBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.elseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseBlock([NotNull] c2022v2Parser.ElseBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.forBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForBlock([NotNull] c2022v2Parser.ForBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileBlock([NotNull] c2022v2Parser.WhileBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] c2022v2Parser.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] c2022v2Parser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.numericMultiAss"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericMultiAss([NotNull] c2022v2Parser.NumericMultiAssContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.numericMultiOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericMultiOp([NotNull] c2022v2Parser.NumericMultiOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.numericAddAss"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericAddAss([NotNull] c2022v2Parser.NumericAddAssContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.numericAddOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumericAddOp([NotNull] c2022v2Parser.NumericAddOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.unaryOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryOp([NotNull] c2022v2Parser.UnaryOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.booleanBinaryOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanBinaryOp([NotNull] c2022v2Parser.BooleanBinaryOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.comp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComp([NotNull] c2022v2Parser.CompContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="c2022v2Parser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] c2022v2Parser.ConstantContext context);
}
} // namespace ConsoleApp1.Content
