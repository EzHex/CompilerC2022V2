﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\modes\OneDrive\Stalinis kompiuteris\New folder\CompilerC2022V2\Solution1\ConsoleApp1\Content\c2022v2.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ConsoleApp1.Content {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class c2022v2Lexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, PRINT=40, BIND=41, TYPE=42, INTEGER=43, DOUBLE=44, CHAR=45, 
		BOOL=46, NULL=47, IDENTIFIER=48, COMMENT=49, WS=50;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "PRINT", "BIND", 
		"TYPE", "INTEGER", "DOUBLE", "CHAR", "BOOL", "NULL", "IDENTIFIER", "COMMENT", 
		"WS"
	};


	public c2022v2Lexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'main:'", "'endMain'", "';'", "'fun'", "'('", "','", "')'", "'endFun'", 
		"'='", "'['", "']'", "'if'", "'ifend'", "'elseif'", "'else'", "'for'", 
		"'forend'", "'while'", "'whileend'", "'*='", "'/='", "'%='", "'+='", "'-='", 
		"'*'", "'/'", "'%'", "'+'", "'-'", "'++'", "'--'", "'||'", "'&&'", "'=='", 
		"'!='", "'>'", "'<'", "'<='", "'>='", "'print'", null, null, null, null, 
		null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, "PRINT", "BIND", "TYPE", "INTEGER", "DOUBLE", 
		"CHAR", "BOOL", "NULL", "IDENTIFIER", "COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "c2022v2.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x34\x165\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE"+
		"\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3"+
		"\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3"+
		"\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3"+
		"\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3"+
		"\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3"+
		"\x18\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3"+
		"\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3!\x3!\x3"+
		"!\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3$\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3"+
		"\'\x3(\x3(\x3(\x3)\x3)\x3)\x3)\x3)\x3)\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3"+
		"*\x3*\x3*\x5*\x103\n*\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x3+"+
		"\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x3+\x5+\x11A\n+\x3,\x6,\x11D\n,\r,\xE"+
		",\x11E\x3-\x6-\x122\n-\r-\xE-\x123\x3-\x3-\x6-\x128\n-\r-\xE-\x129\x3"+
		".\x3.\x3.\x3.\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x3/\x5/\x139\n/\x3\x30\x3"+
		"\x30\x3\x30\x3\x30\x3\x30\x3\x31\x3\x31\a\x31\x142\n\x31\f\x31\xE\x31"+
		"\x145\v\x31\x3\x32\x3\x32\x3\x32\x3\x32\a\x32\x14B\n\x32\f\x32\xE\x32"+
		"\x14E\v\x32\x3\x32\x3\x32\x3\x32\x3\x32\a\x32\x154\n\x32\f\x32\xE\x32"+
		"\x157\v\x32\x3\x32\x3\x32\x5\x32\x15B\n\x32\x3\x32\x3\x32\x3\x33\x6\x33"+
		"\x160\n\x33\r\x33\xE\x33\x161\x3\x33\x3\x33\x3\x155\x2\x2\x34\x3\x2\x3"+
		"\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15"+
		"\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13"+
		"%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B"+
		"\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45"+
		"\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2.[\x2/]\x2\x30_"+
		"\x2\x31\x61\x2\x32\x63\x2\x33\x65\x2\x34\x3\x2\b\x3\x2\x32;\x4\x2\x43"+
		"\\\x63|\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x4\x2\f"+
		"\f\xF\xF\x5\x2\v\f\xF\xF\"\"\x172\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2"+
		"\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2"+
		"\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2"+
		"\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3"+
		"\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2"+
		"\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2"+
		"\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2"+
		"\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2"+
		"\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2"+
		"\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2"+
		"\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3"+
		"\x2\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2\x2]\x3\x2\x2\x2\x2_\x3\x2\x2"+
		"\x2\x2\x61\x3\x2\x2\x2\x2\x63\x3\x2\x2\x2\x2\x65\x3\x2\x2\x2\x3g\x3\x2"+
		"\x2\x2\x5m\x3\x2\x2\x2\au\x3\x2\x2\x2\tw\x3\x2\x2\x2\v{\x3\x2\x2\x2\r"+
		"}\x3\x2\x2\x2\xF\x7F\x3\x2\x2\x2\x11\x81\x3\x2\x2\x2\x13\x88\x3\x2\x2"+
		"\x2\x15\x8A\x3\x2\x2\x2\x17\x8C\x3\x2\x2\x2\x19\x8E\x3\x2\x2\x2\x1B\x91"+
		"\x3\x2\x2\x2\x1D\x97\x3\x2\x2\x2\x1F\x9E\x3\x2\x2\x2!\xA3\x3\x2\x2\x2"+
		"#\xA7\x3\x2\x2\x2%\xAE\x3\x2\x2\x2\'\xB4\x3\x2\x2\x2)\xBD\x3\x2\x2\x2"+
		"+\xC0\x3\x2\x2\x2-\xC3\x3\x2\x2\x2/\xC6\x3\x2\x2\x2\x31\xC9\x3\x2\x2\x2"+
		"\x33\xCC\x3\x2\x2\x2\x35\xCE\x3\x2\x2\x2\x37\xD0\x3\x2\x2\x2\x39\xD2\x3"+
		"\x2\x2\x2;\xD4\x3\x2\x2\x2=\xD6\x3\x2\x2\x2?\xD9\x3\x2\x2\x2\x41\xDC\x3"+
		"\x2\x2\x2\x43\xDF\x3\x2\x2\x2\x45\xE2\x3\x2\x2\x2G\xE5\x3\x2\x2\x2I\xE8"+
		"\x3\x2\x2\x2K\xEA\x3\x2\x2\x2M\xEC\x3\x2\x2\x2O\xEF\x3\x2\x2\x2Q\xF2\x3"+
		"\x2\x2\x2S\x102\x3\x2\x2\x2U\x119\x3\x2\x2\x2W\x11C\x3\x2\x2\x2Y\x121"+
		"\x3\x2\x2\x2[\x12B\x3\x2\x2\x2]\x138\x3\x2\x2\x2_\x13A\x3\x2\x2\x2\x61"+
		"\x13F\x3\x2\x2\x2\x63\x15A\x3\x2\x2\x2\x65\x15F\x3\x2\x2\x2gh\ao\x2\x2"+
		"hi\a\x63\x2\x2ij\ak\x2\x2jk\ap\x2\x2kl\a<\x2\x2l\x4\x3\x2\x2\x2mn\ag\x2"+
		"\x2no\ap\x2\x2op\a\x66\x2\x2pq\aO\x2\x2qr\a\x63\x2\x2rs\ak\x2\x2st\ap"+
		"\x2\x2t\x6\x3\x2\x2\x2uv\a=\x2\x2v\b\x3\x2\x2\x2wx\ah\x2\x2xy\aw\x2\x2"+
		"yz\ap\x2\x2z\n\x3\x2\x2\x2{|\a*\x2\x2|\f\x3\x2\x2\x2}~\a.\x2\x2~\xE\x3"+
		"\x2\x2\x2\x7F\x80\a+\x2\x2\x80\x10\x3\x2\x2\x2\x81\x82\ag\x2\x2\x82\x83"+
		"\ap\x2\x2\x83\x84\a\x66\x2\x2\x84\x85\aH\x2\x2\x85\x86\aw\x2\x2\x86\x87"+
		"\ap\x2\x2\x87\x12\x3\x2\x2\x2\x88\x89\a?\x2\x2\x89\x14\x3\x2\x2\x2\x8A"+
		"\x8B\a]\x2\x2\x8B\x16\x3\x2\x2\x2\x8C\x8D\a_\x2\x2\x8D\x18\x3\x2\x2\x2"+
		"\x8E\x8F\ak\x2\x2\x8F\x90\ah\x2\x2\x90\x1A\x3\x2\x2\x2\x91\x92\ak\x2\x2"+
		"\x92\x93\ah\x2\x2\x93\x94\ag\x2\x2\x94\x95\ap\x2\x2\x95\x96\a\x66\x2\x2"+
		"\x96\x1C\x3\x2\x2\x2\x97\x98\ag\x2\x2\x98\x99\an\x2\x2\x99\x9A\au\x2\x2"+
		"\x9A\x9B\ag\x2\x2\x9B\x9C\ak\x2\x2\x9C\x9D\ah\x2\x2\x9D\x1E\x3\x2\x2\x2"+
		"\x9E\x9F\ag\x2\x2\x9F\xA0\an\x2\x2\xA0\xA1\au\x2\x2\xA1\xA2\ag\x2\x2\xA2"+
		" \x3\x2\x2\x2\xA3\xA4\ah\x2\x2\xA4\xA5\aq\x2\x2\xA5\xA6\at\x2\x2\xA6\""+
		"\x3\x2\x2\x2\xA7\xA8\ah\x2\x2\xA8\xA9\aq\x2\x2\xA9\xAA\at\x2\x2\xAA\xAB"+
		"\ag\x2\x2\xAB\xAC\ap\x2\x2\xAC\xAD\a\x66\x2\x2\xAD$\x3\x2\x2\x2\xAE\xAF"+
		"\ay\x2\x2\xAF\xB0\aj\x2\x2\xB0\xB1\ak\x2\x2\xB1\xB2\an\x2\x2\xB2\xB3\a"+
		"g\x2\x2\xB3&\x3\x2\x2\x2\xB4\xB5\ay\x2\x2\xB5\xB6\aj\x2\x2\xB6\xB7\ak"+
		"\x2\x2\xB7\xB8\an\x2\x2\xB8\xB9\ag\x2\x2\xB9\xBA\ag\x2\x2\xBA\xBB\ap\x2"+
		"\x2\xBB\xBC\a\x66\x2\x2\xBC(\x3\x2\x2\x2\xBD\xBE\a,\x2\x2\xBE\xBF\a?\x2"+
		"\x2\xBF*\x3\x2\x2\x2\xC0\xC1\a\x31\x2\x2\xC1\xC2\a?\x2\x2\xC2,\x3\x2\x2"+
		"\x2\xC3\xC4\a\'\x2\x2\xC4\xC5\a?\x2\x2\xC5.\x3\x2\x2\x2\xC6\xC7\a-\x2"+
		"\x2\xC7\xC8\a?\x2\x2\xC8\x30\x3\x2\x2\x2\xC9\xCA\a/\x2\x2\xCA\xCB\a?\x2"+
		"\x2\xCB\x32\x3\x2\x2\x2\xCC\xCD\a,\x2\x2\xCD\x34\x3\x2\x2\x2\xCE\xCF\a"+
		"\x31\x2\x2\xCF\x36\x3\x2\x2\x2\xD0\xD1\a\'\x2\x2\xD1\x38\x3\x2\x2\x2\xD2"+
		"\xD3\a-\x2\x2\xD3:\x3\x2\x2\x2\xD4\xD5\a/\x2\x2\xD5<\x3\x2\x2\x2\xD6\xD7"+
		"\a-\x2\x2\xD7\xD8\a-\x2\x2\xD8>\x3\x2\x2\x2\xD9\xDA\a/\x2\x2\xDA\xDB\a"+
		"/\x2\x2\xDB@\x3\x2\x2\x2\xDC\xDD\a~\x2\x2\xDD\xDE\a~\x2\x2\xDE\x42\x3"+
		"\x2\x2\x2\xDF\xE0\a(\x2\x2\xE0\xE1\a(\x2\x2\xE1\x44\x3\x2\x2\x2\xE2\xE3"+
		"\a?\x2\x2\xE3\xE4\a?\x2\x2\xE4\x46\x3\x2\x2\x2\xE5\xE6\a#\x2\x2\xE6\xE7"+
		"\a?\x2\x2\xE7H\x3\x2\x2\x2\xE8\xE9\a@\x2\x2\xE9J\x3\x2\x2\x2\xEA\xEB\a"+
		">\x2\x2\xEBL\x3\x2\x2\x2\xEC\xED\a>\x2\x2\xED\xEE\a?\x2\x2\xEEN\x3\x2"+
		"\x2\x2\xEF\xF0\a@\x2\x2\xF0\xF1\a?\x2\x2\xF1P\x3\x2\x2\x2\xF2\xF3\ar\x2"+
		"\x2\xF3\xF4\at\x2\x2\xF4\xF5\ak\x2\x2\xF5\xF6\ap\x2\x2\xF6\xF7\av\x2\x2"+
		"\xF7R\x3\x2\x2\x2\xF8\xF9\a\x64\x2\x2\xF9\xFA\ak\x2\x2\xFA\xFB\ap\x2\x2"+
		"\xFB\x103\a\x66\x2\x2\xFC\xFD\aw\x2\x2\xFD\xFE\ap\x2\x2\xFE\xFF\a\x64"+
		"\x2\x2\xFF\x100\ak\x2\x2\x100\x101\ap\x2\x2\x101\x103\a\x66\x2\x2\x102"+
		"\xF8\x3\x2\x2\x2\x102\xFC\x3\x2\x2\x2\x103T\x3\x2\x2\x2\x104\x105\ak\x2"+
		"\x2\x105\x106\ap\x2\x2\x106\x11A\av\x2\x2\x107\x108\a\x66\x2\x2\x108\x109"+
		"\aq\x2\x2\x109\x10A\aw\x2\x2\x10A\x10B\a\x64\x2\x2\x10B\x10C\an\x2\x2"+
		"\x10C\x11A\ag\x2\x2\x10D\x10E\a\x65\x2\x2\x10E\x10F\aj\x2\x2\x10F\x110"+
		"\a\x63\x2\x2\x110\x11A\at\x2\x2\x111\x112\a\x64\x2\x2\x112\x113\aq\x2"+
		"\x2\x113\x114\aq\x2\x2\x114\x11A\an\x2\x2\x115\x116\ax\x2\x2\x116\x117"+
		"\aq\x2\x2\x117\x118\ak\x2\x2\x118\x11A\a\x66\x2\x2\x119\x104\x3\x2\x2"+
		"\x2\x119\x107\x3\x2\x2\x2\x119\x10D\x3\x2\x2\x2\x119\x111\x3\x2\x2\x2"+
		"\x119\x115\x3\x2\x2\x2\x11AV\x3\x2\x2\x2\x11B\x11D\t\x2\x2\x2\x11C\x11B"+
		"\x3\x2\x2\x2\x11D\x11E\x3\x2\x2\x2\x11E\x11C\x3\x2\x2\x2\x11E\x11F\x3"+
		"\x2\x2\x2\x11FX\x3\x2\x2\x2\x120\x122\t\x2\x2\x2\x121\x120\x3\x2\x2\x2"+
		"\x122\x123\x3\x2\x2\x2\x123\x121\x3\x2\x2\x2\x123\x124\x3\x2\x2\x2\x124"+
		"\x125\x3\x2\x2\x2\x125\x127\a\x30\x2\x2\x126\x128\t\x2\x2\x2\x127\x126"+
		"\x3\x2\x2\x2\x128\x129\x3\x2\x2\x2\x129\x127\x3\x2\x2\x2\x129\x12A\x3"+
		"\x2\x2\x2\x12AZ\x3\x2\x2\x2\x12B\x12C\a)\x2\x2\x12C\x12D\t\x3\x2\x2\x12D"+
		"\x12E\a)\x2\x2\x12E\\\x3\x2\x2\x2\x12F\x130\av\x2\x2\x130\x131\at\x2\x2"+
		"\x131\x132\aw\x2\x2\x132\x139\ag\x2\x2\x133\x134\ah\x2\x2\x134\x135\a"+
		"\x63\x2\x2\x135\x136\an\x2\x2\x136\x137\au\x2\x2\x137\x139\ag\x2\x2\x138"+
		"\x12F\x3\x2\x2\x2\x138\x133\x3\x2\x2\x2\x139^\x3\x2\x2\x2\x13A\x13B\a"+
		"p\x2\x2\x13B\x13C\aw\x2\x2\x13C\x13D\an\x2\x2\x13D\x13E\an\x2\x2\x13E"+
		"`\x3\x2\x2\x2\x13F\x143\t\x4\x2\x2\x140\x142\t\x5\x2\x2\x141\x140\x3\x2"+
		"\x2\x2\x142\x145\x3\x2\x2\x2\x143\x141\x3\x2\x2\x2\x143\x144\x3\x2\x2"+
		"\x2\x144\x62\x3\x2\x2\x2\x145\x143\x3\x2\x2\x2\x146\x147\a\x31\x2\x2\x147"+
		"\x148\a\x31\x2\x2\x148\x14C\x3\x2\x2\x2\x149\x14B\n\x6\x2\x2\x14A\x149"+
		"\x3\x2\x2\x2\x14B\x14E\x3\x2\x2\x2\x14C\x14A\x3\x2\x2\x2\x14C\x14D\x3"+
		"\x2\x2\x2\x14D\x15B\x3\x2\x2\x2\x14E\x14C\x3\x2\x2\x2\x14F\x150\a\x31"+
		"\x2\x2\x150\x151\a,\x2\x2\x151\x155\x3\x2\x2\x2\x152\x154\v\x2\x2\x2\x153"+
		"\x152\x3\x2\x2\x2\x154\x157\x3\x2\x2\x2\x155\x156\x3\x2\x2\x2\x155\x153"+
		"\x3\x2\x2\x2\x156\x158\x3\x2\x2\x2\x157\x155\x3\x2\x2\x2\x158\x159\a,"+
		"\x2\x2\x159\x15B\a\x31\x2\x2\x15A\x146\x3\x2\x2\x2\x15A\x14F\x3\x2\x2"+
		"\x2\x15B\x15C\x3\x2\x2\x2\x15C\x15D\b\x32\x2\x2\x15D\x64\x3\x2\x2\x2\x15E"+
		"\x160\t\a\x2\x2\x15F\x15E\x3\x2\x2\x2\x160\x161\x3\x2\x2\x2\x161\x15F"+
		"\x3\x2\x2\x2\x161\x162\x3\x2\x2\x2\x162\x163\x3\x2\x2\x2\x163\x164\b\x33"+
		"\x2\x2\x164\x66\x3\x2\x2\x2\xE\x2\x102\x119\x11E\x123\x129\x138\x143\x14C"+
		"\x155\x15A\x161\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ConsoleApp1.Content
