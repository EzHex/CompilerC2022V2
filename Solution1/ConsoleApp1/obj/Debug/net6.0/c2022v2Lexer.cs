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
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, PRINT=37, BIND=38, TYPE=39, 
		INTEGER=40, DOUBLE=41, CHAR=42, BOOL=43, NULL=44, IDENTIFIER=45, COMMENT=46, 
		WS=47;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "PRINT", "BIND", "TYPE", "INTEGER", "DOUBLE", 
		"CHAR", "BOOL", "NULL", "IDENTIFIER", "COMMENT", "WS"
	};


	public c2022v2Lexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'='", "'['", "']'", "'('", "','", "')'", "'if'", "'ifend'", 
		"'elseif'", "'else'", "'for'", "'forend'", "'while'", "'whileend'", "'!'", 
		"'*='", "'/='", "'%='", "'*'", "'/'", "'%'", "'+='", "'-='", "'+'", "'-'", 
		"'++'", "'--'", "'||'", "'&&'", "'=='", "'!='", "'>'", "'<'", "'<='", 
		"'>='", "'print'", null, null, null, null, null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, "PRINT", "BIND", "TYPE", "INTEGER", "DOUBLE", "CHAR", "BOOL", "NULL", 
		"IDENTIFIER", "COMMENT", "WS"
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
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x31\x148\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x3\x2\x3\x2\x3"+
		"\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t"+
		"\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v"+
		"\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3"+
		"\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12"+
		"\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15"+
		"\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19"+
		"\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D"+
		"\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3!\x3!\x3!\x3"+
		"\"\x3\"\x3#\x3#\x3$\x3$\x3$\x3%\x3%\x3%\x3&\x3&\x3&\x3&\x3&\x3&\x3\'\x3"+
		"\'\x3\'\x3\'\x3\'\x3\'\x3\'\x3\'\x3\'\x3\'\x5\'\xE6\n\'\x3(\x3(\x3(\x3"+
		"(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3("+
		"\x5(\xFD\n(\x3)\x6)\x100\n)\r)\xE)\x101\x3*\x6*\x105\n*\r*\xE*\x106\x3"+
		"*\x3*\x6*\x10B\n*\r*\xE*\x10C\x3+\x3+\x3+\x3+\x3,\x3,\x3,\x3,\x3,\x3,"+
		"\x3,\x3,\x3,\x5,\x11C\n,\x3-\x3-\x3-\x3-\x3-\x3.\x3.\a.\x125\n.\f.\xE"+
		".\x128\v.\x3/\x3/\x3/\x3/\a/\x12E\n/\f/\xE/\x131\v/\x3/\x3/\x3/\x3/\a"+
		"/\x137\n/\f/\xE/\x13A\v/\x3/\x3/\x5/\x13E\n/\x3/\x3/\x3\x30\x6\x30\x143"+
		"\n\x30\r\x30\xE\x30\x144\x3\x30\x3\x30\x3\x138\x2\x2\x31\x3\x2\x3\x5\x2"+
		"\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17"+
		"\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14"+
		"\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2"+
		"\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$"+
		"G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2.[\x2/]\x2\x30_\x2\x31"+
		"\x3\x2\b\x3\x2\x32;\x4\x2\x43\\\x63|\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32"+
		";\x43\\\x61\x61\x63|\x4\x2\f\f\xF\xF\x5\x2\v\f\xF\xF\"\"\x155\x2\x3\x3"+
		"\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3"+
		"\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13"+
		"\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2"+
		"\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2"+
		"\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2"+
		"+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33"+
		"\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2"+
		"\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2"+
		"\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2"+
		"K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2"+
		"\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2"+
		"\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x3\x61\x3\x2\x2\x2\x5\x63\x3\x2\x2\x2"+
		"\a\x65\x3\x2\x2\x2\tg\x3\x2\x2\x2\vi\x3\x2\x2\x2\rk\x3\x2\x2\x2\xFm\x3"+
		"\x2\x2\x2\x11o\x3\x2\x2\x2\x13r\x3\x2\x2\x2\x15x\x3\x2\x2\x2\x17\x7F\x3"+
		"\x2\x2\x2\x19\x84\x3\x2\x2\x2\x1B\x88\x3\x2\x2\x2\x1D\x8F\x3\x2\x2\x2"+
		"\x1F\x95\x3\x2\x2\x2!\x9E\x3\x2\x2\x2#\xA0\x3\x2\x2\x2%\xA3\x3\x2\x2\x2"+
		"\'\xA6\x3\x2\x2\x2)\xA9\x3\x2\x2\x2+\xAB\x3\x2\x2\x2-\xAD\x3\x2\x2\x2"+
		"/\xAF\x3\x2\x2\x2\x31\xB2\x3\x2\x2\x2\x33\xB5\x3\x2\x2\x2\x35\xB7\x3\x2"+
		"\x2\x2\x37\xB9\x3\x2\x2\x2\x39\xBC\x3\x2\x2\x2;\xBF\x3\x2\x2\x2=\xC2\x3"+
		"\x2\x2\x2?\xC5\x3\x2\x2\x2\x41\xC8\x3\x2\x2\x2\x43\xCB\x3\x2\x2\x2\x45"+
		"\xCD\x3\x2\x2\x2G\xCF\x3\x2\x2\x2I\xD2\x3\x2\x2\x2K\xD5\x3\x2\x2\x2M\xE5"+
		"\x3\x2\x2\x2O\xFC\x3\x2\x2\x2Q\xFF\x3\x2\x2\x2S\x104\x3\x2\x2\x2U\x10E"+
		"\x3\x2\x2\x2W\x11B\x3\x2\x2\x2Y\x11D\x3\x2\x2\x2[\x122\x3\x2\x2\x2]\x13D"+
		"\x3\x2\x2\x2_\x142\x3\x2\x2\x2\x61\x62\a=\x2\x2\x62\x4\x3\x2\x2\x2\x63"+
		"\x64\a?\x2\x2\x64\x6\x3\x2\x2\x2\x65\x66\a]\x2\x2\x66\b\x3\x2\x2\x2gh"+
		"\a_\x2\x2h\n\x3\x2\x2\x2ij\a*\x2\x2j\f\x3\x2\x2\x2kl\a.\x2\x2l\xE\x3\x2"+
		"\x2\x2mn\a+\x2\x2n\x10\x3\x2\x2\x2op\ak\x2\x2pq\ah\x2\x2q\x12\x3\x2\x2"+
		"\x2rs\ak\x2\x2st\ah\x2\x2tu\ag\x2\x2uv\ap\x2\x2vw\a\x66\x2\x2w\x14\x3"+
		"\x2\x2\x2xy\ag\x2\x2yz\an\x2\x2z{\au\x2\x2{|\ag\x2\x2|}\ak\x2\x2}~\ah"+
		"\x2\x2~\x16\x3\x2\x2\x2\x7F\x80\ag\x2\x2\x80\x81\an\x2\x2\x81\x82\au\x2"+
		"\x2\x82\x83\ag\x2\x2\x83\x18\x3\x2\x2\x2\x84\x85\ah\x2\x2\x85\x86\aq\x2"+
		"\x2\x86\x87\at\x2\x2\x87\x1A\x3\x2\x2\x2\x88\x89\ah\x2\x2\x89\x8A\aq\x2"+
		"\x2\x8A\x8B\at\x2\x2\x8B\x8C\ag\x2\x2\x8C\x8D\ap\x2\x2\x8D\x8E\a\x66\x2"+
		"\x2\x8E\x1C\x3\x2\x2\x2\x8F\x90\ay\x2\x2\x90\x91\aj\x2\x2\x91\x92\ak\x2"+
		"\x2\x92\x93\an\x2\x2\x93\x94\ag\x2\x2\x94\x1E\x3\x2\x2\x2\x95\x96\ay\x2"+
		"\x2\x96\x97\aj\x2\x2\x97\x98\ak\x2\x2\x98\x99\an\x2\x2\x99\x9A\ag\x2\x2"+
		"\x9A\x9B\ag\x2\x2\x9B\x9C\ap\x2\x2\x9C\x9D\a\x66\x2\x2\x9D \x3\x2\x2\x2"+
		"\x9E\x9F\a#\x2\x2\x9F\"\x3\x2\x2\x2\xA0\xA1\a,\x2\x2\xA1\xA2\a?\x2\x2"+
		"\xA2$\x3\x2\x2\x2\xA3\xA4\a\x31\x2\x2\xA4\xA5\a?\x2\x2\xA5&\x3\x2\x2\x2"+
		"\xA6\xA7\a\'\x2\x2\xA7\xA8\a?\x2\x2\xA8(\x3\x2\x2\x2\xA9\xAA\a,\x2\x2"+
		"\xAA*\x3\x2\x2\x2\xAB\xAC\a\x31\x2\x2\xAC,\x3\x2\x2\x2\xAD\xAE\a\'\x2"+
		"\x2\xAE.\x3\x2\x2\x2\xAF\xB0\a-\x2\x2\xB0\xB1\a?\x2\x2\xB1\x30\x3\x2\x2"+
		"\x2\xB2\xB3\a/\x2\x2\xB3\xB4\a?\x2\x2\xB4\x32\x3\x2\x2\x2\xB5\xB6\a-\x2"+
		"\x2\xB6\x34\x3\x2\x2\x2\xB7\xB8\a/\x2\x2\xB8\x36\x3\x2\x2\x2\xB9\xBA\a"+
		"-\x2\x2\xBA\xBB\a-\x2\x2\xBB\x38\x3\x2\x2\x2\xBC\xBD\a/\x2\x2\xBD\xBE"+
		"\a/\x2\x2\xBE:\x3\x2\x2\x2\xBF\xC0\a~\x2\x2\xC0\xC1\a~\x2\x2\xC1<\x3\x2"+
		"\x2\x2\xC2\xC3\a(\x2\x2\xC3\xC4\a(\x2\x2\xC4>\x3\x2\x2\x2\xC5\xC6\a?\x2"+
		"\x2\xC6\xC7\a?\x2\x2\xC7@\x3\x2\x2\x2\xC8\xC9\a#\x2\x2\xC9\xCA\a?\x2\x2"+
		"\xCA\x42\x3\x2\x2\x2\xCB\xCC\a@\x2\x2\xCC\x44\x3\x2\x2\x2\xCD\xCE\a>\x2"+
		"\x2\xCE\x46\x3\x2\x2\x2\xCF\xD0\a>\x2\x2\xD0\xD1\a?\x2\x2\xD1H\x3\x2\x2"+
		"\x2\xD2\xD3\a@\x2\x2\xD3\xD4\a?\x2\x2\xD4J\x3\x2\x2\x2\xD5\xD6\ar\x2\x2"+
		"\xD6\xD7\at\x2\x2\xD7\xD8\ak\x2\x2\xD8\xD9\ap\x2\x2\xD9\xDA\av\x2\x2\xDA"+
		"L\x3\x2\x2\x2\xDB\xDC\a\x64\x2\x2\xDC\xDD\ak\x2\x2\xDD\xDE\ap\x2\x2\xDE"+
		"\xE6\a\x66\x2\x2\xDF\xE0\aw\x2\x2\xE0\xE1\ap\x2\x2\xE1\xE2\a\x64\x2\x2"+
		"\xE2\xE3\ak\x2\x2\xE3\xE4\ap\x2\x2\xE4\xE6\a\x66\x2\x2\xE5\xDB\x3\x2\x2"+
		"\x2\xE5\xDF\x3\x2\x2\x2\xE6N\x3\x2\x2\x2\xE7\xE8\ak\x2\x2\xE8\xE9\ap\x2"+
		"\x2\xE9\xFD\av\x2\x2\xEA\xEB\a\x66\x2\x2\xEB\xEC\aq\x2\x2\xEC\xED\aw\x2"+
		"\x2\xED\xEE\a\x64\x2\x2\xEE\xEF\an\x2\x2\xEF\xFD\ag\x2\x2\xF0\xF1\a\x65"+
		"\x2\x2\xF1\xF2\aj\x2\x2\xF2\xF3\a\x63\x2\x2\xF3\xFD\at\x2\x2\xF4\xF5\a"+
		"\x64\x2\x2\xF5\xF6\aq\x2\x2\xF6\xF7\aq\x2\x2\xF7\xFD\an\x2\x2\xF8\xF9"+
		"\ax\x2\x2\xF9\xFA\aq\x2\x2\xFA\xFB\ak\x2\x2\xFB\xFD\a\x66\x2\x2\xFC\xE7"+
		"\x3\x2\x2\x2\xFC\xEA\x3\x2\x2\x2\xFC\xF0\x3\x2\x2\x2\xFC\xF4\x3\x2\x2"+
		"\x2\xFC\xF8\x3\x2\x2\x2\xFDP\x3\x2\x2\x2\xFE\x100\t\x2\x2\x2\xFF\xFE\x3"+
		"\x2\x2\x2\x100\x101\x3\x2\x2\x2\x101\xFF\x3\x2\x2\x2\x101\x102\x3\x2\x2"+
		"\x2\x102R\x3\x2\x2\x2\x103\x105\t\x2\x2\x2\x104\x103\x3\x2\x2\x2\x105"+
		"\x106\x3\x2\x2\x2\x106\x104\x3\x2\x2\x2\x106\x107\x3\x2\x2\x2\x107\x108"+
		"\x3\x2\x2\x2\x108\x10A\a\x30\x2\x2\x109\x10B\t\x2\x2\x2\x10A\x109\x3\x2"+
		"\x2\x2\x10B\x10C\x3\x2\x2\x2\x10C\x10A\x3\x2\x2\x2\x10C\x10D\x3\x2\x2"+
		"\x2\x10DT\x3\x2\x2\x2\x10E\x10F\a)\x2\x2\x10F\x110\t\x3\x2\x2\x110\x111"+
		"\a)\x2\x2\x111V\x3\x2\x2\x2\x112\x113\av\x2\x2\x113\x114\at\x2\x2\x114"+
		"\x115\aw\x2\x2\x115\x11C\ag\x2\x2\x116\x117\ah\x2\x2\x117\x118\a\x63\x2"+
		"\x2\x118\x119\an\x2\x2\x119\x11A\au\x2\x2\x11A\x11C\ag\x2\x2\x11B\x112"+
		"\x3\x2\x2\x2\x11B\x116\x3\x2\x2\x2\x11CX\x3\x2\x2\x2\x11D\x11E\ap\x2\x2"+
		"\x11E\x11F\aw\x2\x2\x11F\x120\an\x2\x2\x120\x121\an\x2\x2\x121Z\x3\x2"+
		"\x2\x2\x122\x126\t\x4\x2\x2\x123\x125\t\x5\x2\x2\x124\x123\x3\x2\x2\x2"+
		"\x125\x128\x3\x2\x2\x2\x126\x124\x3\x2\x2\x2\x126\x127\x3\x2\x2\x2\x127"+
		"\\\x3\x2\x2\x2\x128\x126\x3\x2\x2\x2\x129\x12A\a\x31\x2\x2\x12A\x12B\a"+
		"\x31\x2\x2\x12B\x12F\x3\x2\x2\x2\x12C\x12E\n\x6\x2\x2\x12D\x12C\x3\x2"+
		"\x2\x2\x12E\x131\x3\x2\x2\x2\x12F\x12D\x3\x2\x2\x2\x12F\x130\x3\x2\x2"+
		"\x2\x130\x13E\x3\x2\x2\x2\x131\x12F\x3\x2\x2\x2\x132\x133\a\x31\x2\x2"+
		"\x133\x134\a,\x2\x2\x134\x138\x3\x2\x2\x2\x135\x137\v\x2\x2\x2\x136\x135"+
		"\x3\x2\x2\x2\x137\x13A\x3\x2\x2\x2\x138\x139\x3\x2\x2\x2\x138\x136\x3"+
		"\x2\x2\x2\x139\x13B\x3\x2\x2\x2\x13A\x138\x3\x2\x2\x2\x13B\x13C\a,\x2"+
		"\x2\x13C\x13E\a\x31\x2\x2\x13D\x129\x3\x2\x2\x2\x13D\x132\x3\x2\x2\x2"+
		"\x13E\x13F\x3\x2\x2\x2\x13F\x140\b/\x2\x2\x140^\x3\x2\x2\x2\x141\x143"+
		"\t\a\x2\x2\x142\x141\x3\x2\x2\x2\x143\x144\x3\x2\x2\x2\x144\x142\x3\x2"+
		"\x2\x2\x144\x145\x3\x2\x2\x2\x145\x146\x3\x2\x2\x2\x146\x147\b\x30\x2"+
		"\x2\x147`\x3\x2\x2\x2\xE\x2\xE5\xFC\x101\x106\x10C\x11B\x126\x12F\x138"+
		"\x13D\x144\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ConsoleApp1.Content
