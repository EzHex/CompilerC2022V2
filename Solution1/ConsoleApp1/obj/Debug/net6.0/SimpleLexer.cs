﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\KTUOneDrive\OneDrive - Kaunas University of Technology\4pusmetis\Programavimo kalbų teorija\Compiler\CompilerC2022V2\Solution1\ConsoleApp1\Content\Simple.g4 by ANTLR 4.6.6

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
public partial class SimpleLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, IDENTIFIER=24, 
		WS=25;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "IDENTIFIER", "WS"
	};


	public SimpleLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'if'", "'('", "')'", "'else'", "'for'", "'while'", "'='", 
		"','", "'!'", "'*'", "'/'", "'%'", "'+'", "'-'", "'=='", "'!='", "'>'", 
		"'<'", "'<='", "'>='", "'{'", "'}'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"IDENTIFIER", "WS"
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

	public override string GrammarFileName { get { return "Simple.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x1B\x7F\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3"+
		"\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t"+
		"\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF"+
		"\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13"+
		"\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17"+
		"\x3\x18\x3\x18\x3\x19\x3\x19\a\x19t\n\x19\f\x19\xE\x19w\v\x19\x3\x1A\x6"+
		"\x1Az\n\x1A\r\x1A\xE\x1A{\x3\x1A\x3\x1A\x2\x2\x2\x1B\x3\x2\x3\x5\x2\x4"+
		"\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17"+
		"\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14"+
		"\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x3\x2"+
		"\x5\x5\x2\x43\\\x61\x61\x63|\x5\x2\x32;\x43\\\x63|\x4\x2\v\f\xF\xF\x80"+
		"\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2"+
		"\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2"+
		"\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2"+
		"\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3"+
		"\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2"+
		"\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2"+
		"\x2\x33\x3\x2\x2\x2\x3\x35\x3\x2\x2\x2\x5\x37\x3\x2\x2\x2\a:\x3\x2\x2"+
		"\x2\t<\x3\x2\x2\x2\v>\x3\x2\x2\x2\r\x43\x3\x2\x2\x2\xFG\x3\x2\x2\x2\x11"+
		"M\x3\x2\x2\x2\x13O\x3\x2\x2\x2\x15Q\x3\x2\x2\x2\x17S\x3\x2\x2\x2\x19U"+
		"\x3\x2\x2\x2\x1BW\x3\x2\x2\x2\x1DY\x3\x2\x2\x2\x1F[\x3\x2\x2\x2!]\x3\x2"+
		"\x2\x2#`\x3\x2\x2\x2%\x63\x3\x2\x2\x2\'\x65\x3\x2\x2\x2)g\x3\x2\x2\x2"+
		"+j\x3\x2\x2\x2-m\x3\x2\x2\x2/o\x3\x2\x2\x2\x31q\x3\x2\x2\x2\x33y\x3\x2"+
		"\x2\x2\x35\x36\a=\x2\x2\x36\x4\x3\x2\x2\x2\x37\x38\ak\x2\x2\x38\x39\a"+
		"h\x2\x2\x39\x6\x3\x2\x2\x2:;\a*\x2\x2;\b\x3\x2\x2\x2<=\a+\x2\x2=\n\x3"+
		"\x2\x2\x2>?\ag\x2\x2?@\an\x2\x2@\x41\au\x2\x2\x41\x42\ag\x2\x2\x42\f\x3"+
		"\x2\x2\x2\x43\x44\ah\x2\x2\x44\x45\aq\x2\x2\x45\x46\at\x2\x2\x46\xE\x3"+
		"\x2\x2\x2GH\ay\x2\x2HI\aj\x2\x2IJ\ak\x2\x2JK\an\x2\x2KL\ag\x2\x2L\x10"+
		"\x3\x2\x2\x2MN\a?\x2\x2N\x12\x3\x2\x2\x2OP\a.\x2\x2P\x14\x3\x2\x2\x2Q"+
		"R\a#\x2\x2R\x16\x3\x2\x2\x2ST\a,\x2\x2T\x18\x3\x2\x2\x2UV\a\x31\x2\x2"+
		"V\x1A\x3\x2\x2\x2WX\a\'\x2\x2X\x1C\x3\x2\x2\x2YZ\a-\x2\x2Z\x1E\x3\x2\x2"+
		"\x2[\\\a/\x2\x2\\ \x3\x2\x2\x2]^\a?\x2\x2^_\a?\x2\x2_\"\x3\x2\x2\x2`\x61"+
		"\a#\x2\x2\x61\x62\a?\x2\x2\x62$\x3\x2\x2\x2\x63\x64\a@\x2\x2\x64&\x3\x2"+
		"\x2\x2\x65\x66\a>\x2\x2\x66(\x3\x2\x2\x2gh\a>\x2\x2hi\a?\x2\x2i*\x3\x2"+
		"\x2\x2jk\a@\x2\x2kl\a?\x2\x2l,\x3\x2\x2\x2mn\a}\x2\x2n.\x3\x2\x2\x2op"+
		"\a\x7F\x2\x2p\x30\x3\x2\x2\x2qu\t\x2\x2\x2rt\t\x3\x2\x2sr\x3\x2\x2\x2"+
		"tw\x3\x2\x2\x2us\x3\x2\x2\x2uv\x3\x2\x2\x2v\x32\x3\x2\x2\x2wu\x3\x2\x2"+
		"\x2xz\t\x4\x2\x2yx\x3\x2\x2\x2z{\x3\x2\x2\x2{y\x3\x2\x2\x2{|\x3\x2\x2"+
		"\x2|}\x3\x2\x2\x2}~\b\x1A\x2\x2~\x34\x3\x2\x2\x2\x5\x2u{\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ConsoleApp1.Content
