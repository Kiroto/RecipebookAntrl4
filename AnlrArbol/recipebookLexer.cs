//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\kirot\source\repos\AnlrArbol\AnlrArbol\recipebook.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class recipebookLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LINE_START=1, GUION=2, REC_LBL=3, POR_LBL=4, TMP_LBL=5, TMC_LBL=6, CAL_LBL=7, 
		ING_LBL=8, ELA_LBL=9, TIME_UNIT=10, MEASURE_UNIT=11, WORD=12, LIST_ORDER_SEP=13, 
		COM=14, SEP=15, TAB=16, WS=17, NL=18, NUMBER=19, FLOAT=20, INTEGER=21, 
		CARRRET=22;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LINE_START", "GUION", "REC_LBL", "POR_LBL", "TMP_LBL", "TMC_LBL", "CAL_LBL", 
		"ING_LBL", "ELA_LBL", "TIME_UNIT", "MEASURE_UNIT", "WORD", "LIST_ORDER_SEP", 
		"COM", "SEP", "TAB", "WS", "NL", "NUMBER", "FLOAT", "INTEGER", "CARRRET"
	};


	public recipebookLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public recipebookLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'-'", "'RECETA'", "'PORCIONES'", "'TIEMPO PREPARACION'", 
		"'TIEMPO COCCION'", "'CALORIAS'", "'INGREDIENTES'", "'ELABORACION'", null, 
		null, null, "')'", "','", "':'", "'\t'", null, "'\n'", null, null, null, 
		"'\r'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LINE_START", "GUION", "REC_LBL", "POR_LBL", "TMP_LBL", "TMC_LBL", 
		"CAL_LBL", "ING_LBL", "ELA_LBL", "TIME_UNIT", "MEASURE_UNIT", "WORD", 
		"LIST_ORDER_SEP", "COM", "SEP", "TAB", "WS", "NL", "NUMBER", "FLOAT", 
		"INTEGER", "CARRRET"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "recipebook.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static recipebookLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x18', '\xF2', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x5', '\v', '\xA5', 
		'\n', '\v', '\x3', '\v', '\x5', '\v', '\xA8', '\n', '\v', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x5', '\f', '\xC2', '\n', '\f', '\x3', '\f', '\x5', '\f', 
		'\xC5', '\n', '\f', '\x3', '\r', '\x6', '\r', '\xC8', '\n', '\r', '\r', 
		'\r', '\xE', '\r', '\xC9', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x12', '\x6', '\x12', '\xD5', '\n', '\x12', '\r', '\x12', '\xE', '\x12', 
		'\xD6', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x5', 
		'\x14', '\xDD', '\n', '\x14', '\x3', '\x15', '\x6', '\x15', '\xE0', '\n', 
		'\x15', '\r', '\x15', '\xE', '\x15', '\xE1', '\x3', '\x15', '\x3', '\x15', 
		'\x6', '\x15', '\xE6', '\n', '\x15', '\r', '\x15', '\xE', '\x15', '\xE7', 
		'\x3', '\x16', '\x6', '\x16', '\xEB', '\n', '\x16', '\r', '\x16', '\xE', 
		'\x16', '\xEC', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x2', '\x2', '\x18', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', 
		'\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', 
		'\x11', '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', 
		'+', '\x17', '-', '\x18', '\x3', '\x2', '\x4', '\x5', '\x2', '\x43', '\\', 
		'\x61', '\x61', '\x63', '|', '\x3', '\x2', '\x32', ';', '\x2', '\x101', 
		'\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x3', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x5', '\x32', '\x3', '\x2', '\x2', '\x2', '\a', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\t', ';', '\x3', '\x2', '\x2', '\x2', '\v', '\x45', 
		'\x3', '\x2', '\x2', '\x2', '\r', 'X', '\x3', '\x2', '\x2', '\x2', '\xF', 
		'g', '\x3', '\x2', '\x2', '\x2', '\x11', 'p', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '}', '\x3', '\x2', '\x2', '\x2', '\x15', '\xA4', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\xC1', '\x3', '\x2', '\x2', '\x2', '\x19', '\xC7', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', '\xCB', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\xCD', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xCF', '\x3', '\x2', 
		'\x2', '\x2', '!', '\xD1', '\x3', '\x2', '\x2', '\x2', '#', '\xD4', '\x3', 
		'\x2', '\x2', '\x2', '%', '\xD8', '\x3', '\x2', '\x2', '\x2', '\'', '\xDC', 
		'\x3', '\x2', '\x2', '\x2', ')', '\xDF', '\x3', '\x2', '\x2', '\x2', '+', 
		'\xEA', '\x3', '\x2', '\x2', '\x2', '-', '\xEE', '\x3', '\x2', '\x2', 
		'\x2', '/', '\x30', '\x5', '\x5', '\x3', '\x2', '\x30', '\x31', '\x5', 
		'#', '\x12', '\x2', '\x31', '\x4', '\x3', '\x2', '\x2', '\x2', '\x32', 
		'\x33', '\a', '/', '\x2', '\x2', '\x33', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'\x34', '\x35', '\a', 'T', '\x2', '\x2', '\x35', '\x36', '\a', 'G', '\x2', 
		'\x2', '\x36', '\x37', '\a', '\x45', '\x2', '\x2', '\x37', '\x38', '\a', 
		'G', '\x2', '\x2', '\x38', '\x39', '\a', 'V', '\x2', '\x2', '\x39', ':', 
		'\a', '\x43', '\x2', '\x2', ':', '\b', '\x3', '\x2', '\x2', '\x2', ';', 
		'<', '\a', 'R', '\x2', '\x2', '<', '=', '\a', 'Q', '\x2', '\x2', '=', 
		'>', '\a', 'T', '\x2', '\x2', '>', '?', '\a', '\x45', '\x2', '\x2', '?', 
		'@', '\a', 'K', '\x2', '\x2', '@', '\x41', '\a', 'Q', '\x2', '\x2', '\x41', 
		'\x42', '\a', 'P', '\x2', '\x2', '\x42', '\x43', '\a', 'G', '\x2', '\x2', 
		'\x43', '\x44', '\a', 'U', '\x2', '\x2', '\x44', '\n', '\x3', '\x2', '\x2', 
		'\x2', '\x45', '\x46', '\a', 'V', '\x2', '\x2', '\x46', 'G', '\a', 'K', 
		'\x2', '\x2', 'G', 'H', '\a', 'G', '\x2', '\x2', 'H', 'I', '\a', 'O', 
		'\x2', '\x2', 'I', 'J', '\a', 'R', '\x2', '\x2', 'J', 'K', '\a', 'Q', 
		'\x2', '\x2', 'K', 'L', '\a', '\"', '\x2', '\x2', 'L', 'M', '\a', 'R', 
		'\x2', '\x2', 'M', 'N', '\a', 'T', '\x2', '\x2', 'N', 'O', '\a', 'G', 
		'\x2', '\x2', 'O', 'P', '\a', 'R', '\x2', '\x2', 'P', 'Q', '\a', '\x43', 
		'\x2', '\x2', 'Q', 'R', '\a', 'T', '\x2', '\x2', 'R', 'S', '\a', '\x43', 
		'\x2', '\x2', 'S', 'T', '\a', '\x45', '\x2', '\x2', 'T', 'U', '\a', 'K', 
		'\x2', '\x2', 'U', 'V', '\a', 'Q', '\x2', '\x2', 'V', 'W', '\a', 'P', 
		'\x2', '\x2', 'W', '\f', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\a', 'V', 
		'\x2', '\x2', 'Y', 'Z', '\a', 'K', '\x2', '\x2', 'Z', '[', '\a', 'G', 
		'\x2', '\x2', '[', '\\', '\a', 'O', '\x2', '\x2', '\\', ']', '\a', 'R', 
		'\x2', '\x2', ']', '^', '\a', 'Q', '\x2', '\x2', '^', '_', '\a', '\"', 
		'\x2', '\x2', '_', '`', '\a', '\x45', '\x2', '\x2', '`', '\x61', '\a', 
		'Q', '\x2', '\x2', '\x61', '\x62', '\a', '\x45', '\x2', '\x2', '\x62', 
		'\x63', '\a', '\x45', '\x2', '\x2', '\x63', '\x64', '\a', 'K', '\x2', 
		'\x2', '\x64', '\x65', '\a', 'Q', '\x2', '\x2', '\x65', '\x66', '\a', 
		'P', '\x2', '\x2', '\x66', '\xE', '\x3', '\x2', '\x2', '\x2', 'g', 'h', 
		'\a', '\x45', '\x2', '\x2', 'h', 'i', '\a', '\x43', '\x2', '\x2', 'i', 
		'j', '\a', 'N', '\x2', '\x2', 'j', 'k', '\a', 'Q', '\x2', '\x2', 'k', 
		'l', '\a', 'T', '\x2', '\x2', 'l', 'm', '\a', 'K', '\x2', '\x2', 'm', 
		'n', '\a', '\x43', '\x2', '\x2', 'n', 'o', '\a', 'U', '\x2', '\x2', 'o', 
		'\x10', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', 'K', '\x2', '\x2', 
		'q', 'r', '\a', 'P', '\x2', '\x2', 'r', 's', '\a', 'I', '\x2', '\x2', 
		's', 't', '\a', 'T', '\x2', '\x2', 't', 'u', '\a', 'G', '\x2', '\x2', 
		'u', 'v', '\a', '\x46', '\x2', '\x2', 'v', 'w', '\a', 'K', '\x2', '\x2', 
		'w', 'x', '\a', 'G', '\x2', '\x2', 'x', 'y', '\a', 'P', '\x2', '\x2', 
		'y', 'z', '\a', 'V', '\x2', '\x2', 'z', '{', '\a', 'G', '\x2', '\x2', 
		'{', '|', '\a', 'U', '\x2', '\x2', '|', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'}', '~', '\a', 'G', '\x2', '\x2', '~', '\x7F', '\a', 'N', '\x2', '\x2', 
		'\x7F', '\x80', '\a', '\x43', '\x2', '\x2', '\x80', '\x81', '\a', '\x44', 
		'\x2', '\x2', '\x81', '\x82', '\a', 'Q', '\x2', '\x2', '\x82', '\x83', 
		'\a', 'T', '\x2', '\x2', '\x83', '\x84', '\a', '\x43', '\x2', '\x2', '\x84', 
		'\x85', '\a', '\x45', '\x2', '\x2', '\x85', '\x86', '\a', 'K', '\x2', 
		'\x2', '\x86', '\x87', '\a', 'Q', '\x2', '\x2', '\x87', '\x88', '\a', 
		'P', '\x2', '\x2', '\x88', '\x14', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'\x8A', '\a', 'o', '\x2', '\x2', '\x8A', '\x8B', '\a', 'k', '\x2', '\x2', 
		'\x8B', '\xA5', '\a', 'p', '\x2', '\x2', '\x8C', '\x8D', '\a', 'o', '\x2', 
		'\x2', '\x8D', '\x8E', '\a', 'k', '\x2', '\x2', '\x8E', '\x8F', '\a', 
		'p', '\x2', '\x2', '\x8F', '\x90', '\a', 'w', '\x2', '\x2', '\x90', '\x91', 
		'\a', 'v', '\x2', '\x2', '\x91', '\xA5', '\a', 'g', '\x2', '\x2', '\x92', 
		'\x93', '\a', 'u', '\x2', '\x2', '\x93', '\x94', '\a', 'g', '\x2', '\x2', 
		'\x94', '\xA5', '\a', '\x65', '\x2', '\x2', '\x95', '\x96', '\a', 'u', 
		'\x2', '\x2', '\x96', '\x97', '\a', 'g', '\x2', '\x2', '\x97', '\x98', 
		'\a', '\x65', '\x2', '\x2', '\x98', '\x99', '\a', 'q', '\x2', '\x2', '\x99', 
		'\x9A', '\a', 'p', '\x2', '\x2', '\x9A', '\xA5', '\a', '\x66', '\x2', 
		'\x2', '\x9B', '\x9C', '\a', 'j', '\x2', '\x2', '\x9C', '\xA5', '\a', 
		't', '\x2', '\x2', '\x9D', '\x9E', '\a', 'j', '\x2', '\x2', '\x9E', '\x9F', 
		'\a', 'q', '\x2', '\x2', '\x9F', '\xA0', '\a', 'w', '\x2', '\x2', '\xA0', 
		'\xA5', '\a', 't', '\x2', '\x2', '\xA1', '\xA2', '\a', '\x66', '\x2', 
		'\x2', '\xA2', '\xA3', '\a', '\x63', '\x2', '\x2', '\xA3', '\xA5', '\a', 
		'{', '\x2', '\x2', '\xA4', '\x89', '\x3', '\x2', '\x2', '\x2', '\xA4', 
		'\x8C', '\x3', '\x2', '\x2', '\x2', '\xA4', '\x92', '\x3', '\x2', '\x2', 
		'\x2', '\xA4', '\x95', '\x3', '\x2', '\x2', '\x2', '\xA4', '\x9B', '\x3', 
		'\x2', '\x2', '\x2', '\xA4', '\x9D', '\x3', '\x2', '\x2', '\x2', '\xA4', 
		'\xA1', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA7', '\x3', '\x2', '\x2', 
		'\x2', '\xA6', '\xA8', '\a', 'u', '\x2', '\x2', '\xA7', '\xA6', '\x3', 
		'\x2', '\x2', '\x2', '\xA7', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xA8', 
		'\x16', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', '\a', 'v', '\x2', 
		'\x2', '\xAA', '\xAB', '\a', '\x63', '\x2', '\x2', '\xAB', '\xAC', '\a', 
		'|', '\x2', '\x2', '\xAC', '\xC2', '\a', '\x63', '\x2', '\x2', '\xAD', 
		'\xAE', '\a', '\x65', '\x2', '\x2', '\xAE', '\xAF', '\a', 'w', '\x2', 
		'\x2', '\xAF', '\xB0', '\a', '\x65', '\x2', '\x2', '\xB0', '\xB1', '\a', 
		'j', '\x2', '\x2', '\xB1', '\xB2', '\a', '\x63', '\x2', '\x2', '\xB2', 
		'\xB3', '\a', 't', '\x2', '\x2', '\xB3', '\xB4', '\a', '\x63', '\x2', 
		'\x2', '\xB4', '\xB5', '\a', '\x66', '\x2', '\x2', '\xB5', '\xB6', '\a', 
		'k', '\x2', '\x2', '\xB6', '\xB7', '\a', 'v', '\x2', '\x2', '\xB7', '\xC2', 
		'\a', '\x63', '\x2', '\x2', '\xB8', '\xB9', '\a', '\x65', '\x2', '\x2', 
		'\xB9', '\xBA', '\a', 'w', '\x2', '\x2', '\xBA', '\xBB', '\a', '\x65', 
		'\x2', '\x2', '\xBB', '\xBC', '\a', 'j', '\x2', '\x2', '\xBC', '\xBD', 
		'\a', '\x63', '\x2', '\x2', '\xBD', '\xBE', '\a', 't', '\x2', '\x2', '\xBE', 
		'\xBF', '\a', '\x63', '\x2', '\x2', '\xBF', '\xC0', '\a', '\x66', '\x2', 
		'\x2', '\xC0', '\xC2', '\a', '\x63', '\x2', '\x2', '\xC1', '\xA9', '\x3', 
		'\x2', '\x2', '\x2', '\xC1', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xC1', 
		'\xB8', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC4', '\x3', '\x2', '\x2', 
		'\x2', '\xC3', '\xC5', '\a', 'u', '\x2', '\x2', '\xC4', '\xC3', '\x3', 
		'\x2', '\x2', '\x2', '\xC4', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC5', 
		'\x18', '\x3', '\x2', '\x2', '\x2', '\xC6', '\xC8', '\t', '\x2', '\x2', 
		'\x2', '\xC7', '\xC6', '\x3', '\x2', '\x2', '\x2', '\xC8', '\xC9', '\x3', 
		'\x2', '\x2', '\x2', '\xC9', '\xC7', '\x3', '\x2', '\x2', '\x2', '\xC9', 
		'\xCA', '\x3', '\x2', '\x2', '\x2', '\xCA', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\xCB', '\xCC', '\a', '+', '\x2', '\x2', '\xCC', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', '\xCD', '\xCE', '\a', '.', '\x2', '\x2', '\xCE', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xD0', '\a', '<', '\x2', 
		'\x2', '\xD0', ' ', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xD2', '\a', 
		'\v', '\x2', '\x2', '\xD2', '\"', '\x3', '\x2', '\x2', '\x2', '\xD3', 
		'\xD5', '\a', '\"', '\x2', '\x2', '\xD4', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '\xD5', '\xD6', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xD4', '\x3', 
		'\x2', '\x2', '\x2', '\xD6', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xD7', 
		'$', '\x3', '\x2', '\x2', '\x2', '\xD8', '\xD9', '\a', '\f', '\x2', '\x2', 
		'\xD9', '&', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xDD', '\x5', '+', '\x16', 
		'\x2', '\xDB', '\xDD', '\x5', ')', '\x15', '\x2', '\xDC', '\xDA', '\x3', 
		'\x2', '\x2', '\x2', '\xDC', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDD', 
		'(', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xE0', '\t', '\x3', '\x2', '\x2', 
		'\xDF', '\xDE', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE1', '\x3', '\x2', 
		'\x2', '\x2', '\xE1', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', 
		'\x3', '\x2', '\x2', '\x2', '\xE2', '\xE3', '\x3', '\x2', '\x2', '\x2', 
		'\xE3', '\xE5', '\a', '\x30', '\x2', '\x2', '\xE4', '\xE6', '\t', '\x3', 
		'\x2', '\x2', '\xE5', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xE6', '\xE7', 
		'\x3', '\x2', '\x2', '\x2', '\xE7', '\xE5', '\x3', '\x2', '\x2', '\x2', 
		'\xE7', '\xE8', '\x3', '\x2', '\x2', '\x2', '\xE8', '*', '\x3', '\x2', 
		'\x2', '\x2', '\xE9', '\xEB', '\t', '\x3', '\x2', '\x2', '\xEA', '\xE9', 
		'\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\x3', '\x2', '\x2', '\x2', 
		'\xEC', '\xEA', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xED', '\x3', '\x2', 
		'\x2', '\x2', '\xED', ',', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xEF', 
		'\a', '\xF', '\x2', '\x2', '\xEF', '\xF0', '\x3', '\x2', '\x2', '\x2', 
		'\xF0', '\xF1', '\b', '\x17', '\x2', '\x2', '\xF1', '.', '\x3', '\x2', 
		'\x2', '\x2', '\r', '\x2', '\xA4', '\xA7', '\xC1', '\xC4', '\xC9', '\xD6', 
		'\xDC', '\xE1', '\xE7', '\xEC', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
