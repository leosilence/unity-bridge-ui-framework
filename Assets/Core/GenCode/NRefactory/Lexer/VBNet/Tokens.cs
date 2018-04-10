// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald" email="daniel@danielgrunwald.de"/>
//     <version>$Revision: 2453 $</version>
// </file>

// this file was autogenerated by a tool.
using System;
using System.Collections;

namespace BridgeUI.NRefactory.Parser.VB
{
	public static class Tokens
	{
		// ----- terminal classes -----
		public const int EOF                  = 0;
		public const int EOL                  = 1;
		public const int Identifier           = 2;
		public const int LiteralString        = 3;
		public const int LiteralCharacter     = 4;
		public const int LiteralInteger       = 5;
		public const int LiteralDouble        = 6;
		public const int LiteralSingle        = 7;
		public const int LiteralDecimal       = 8;
		public const int LiteralDate          = 9;

		// ----- special character -----
		public const int Dot                  = 10;
		public const int Assign               = 11;
		public const int Comma                = 12;
		public const int Colon                = 13;
		public const int Plus                 = 14;
		public const int Minus                = 15;
		public const int Times                = 16;
		public const int Div                  = 17;
		public const int DivInteger           = 18;
		public const int ConcatString         = 19;
		public const int Power                = 20;
		public const int QuestionMark         = 21;
		public const int OpenCurlyBrace       = 22;
		public const int CloseCurlyBrace      = 23;
		public const int OpenParenthesis      = 24;
		public const int CloseParenthesis     = 25;
		public const int GreaterThan          = 26;
		public const int LessThan             = 27;
		public const int NotEqual             = 28;
		public const int GreaterEqual         = 29;
		public const int LessEqual            = 30;
		public const int ShiftLeft            = 31;
		public const int ShiftRight           = 32;
		public const int PlusAssign           = 33;
		public const int PowerAssign          = 34;
		public const int MinusAssign          = 35;
		public const int TimesAssign          = 36;
		public const int DivAssign            = 37;
		public const int DivIntegerAssign     = 38;
		public const int ShiftLeftAssign      = 39;
		public const int ShiftRightAssign     = 40;
		public const int ConcatStringAssign   = 41;

		// ----- keywords -----
		public const int AddHandler           = 42;
		public const int AddressOf            = 43;
		public const int Alias                = 44;
		public const int And                  = 45;
		public const int AndAlso              = 46;
		public const int Ansi                 = 47;
		public const int As                   = 48;
		public const int Assembly             = 49;
		public const int Auto                 = 50;
		public const int Binary               = 51;
		public const int Boolean              = 52;
		public const int ByRef                = 53;
		public const int Byte                 = 54;
		public const int ByVal                = 55;
		public const int Call                 = 56;
		public const int Case                 = 57;
		public const int Catch                = 58;
		public const int CBool                = 59;
		public const int CByte                = 60;
		public const int CChar                = 61;
		public const int CDate                = 62;
		public const int CDbl                 = 63;
		public const int CDec                 = 64;
		public const int Char                 = 65;
		public const int CInt                 = 66;
		public const int Class                = 67;
		public const int CLng                 = 68;
		public const int CObj                 = 69;
		public const int Compare              = 70;
		public const int Const                = 71;
		public const int CShort               = 72;
		public const int CSng                 = 73;
		public const int CStr                 = 74;
		public const int CType                = 75;
		public const int Date                 = 76;
		public const int Decimal              = 77;
		public const int Declare              = 78;
		public const int Default              = 79;
		public const int Delegate             = 80;
		public const int Dim                  = 81;
		public const int DirectCast           = 82;
		public const int Do                   = 83;
		public const int Double               = 84;
		public const int Each                 = 85;
		public const int Else                 = 86;
		public const int ElseIf               = 87;
		public const int End                  = 88;
		public const int EndIf                = 89;
		public const int Enum                 = 90;
		public const int Erase                = 91;
		public const int Error                = 92;
		public const int Event                = 93;
		public const int Exit                 = 94;
		public const int Explicit             = 95;
		public const int False                = 96;
		public const int Finally              = 97;
		public const int For                  = 98;
		public const int Friend               = 99;
		public const int Function             = 100;
		public const int Get                  = 101;
		new public const int GetType              = 102;
		public const int GoSub                = 103;
		public const int GoTo                 = 104;
		public const int Handles              = 105;
		public const int If                   = 106;
		public const int Implements           = 107;
		public const int Imports              = 108;
		public const int In                   = 109;
		public const int Inherits             = 110;
		public const int Integer              = 111;
		public const int Interface            = 112;
		public const int Is                   = 113;
		public const int Let                  = 114;
		public const int Lib                  = 115;
		public const int Like                 = 116;
		public const int Long                 = 117;
		public const int Loop                 = 118;
		public const int Me                   = 119;
		public const int Mod                  = 120;
		public const int Module               = 121;
		public const int MustInherit          = 122;
		public const int MustOverride         = 123;
		public const int MyBase               = 124;
		public const int MyClass              = 125;
		public const int Namespace            = 126;
		public const int New                  = 127;
		public const int Next                 = 128;
		public const int Not                  = 129;
		public const int Nothing              = 130;
		public const int NotInheritable       = 131;
		public const int NotOverridable       = 132;
		public const int Object               = 133;
		public const int Off                  = 134;
		public const int On                   = 135;
		public const int Option               = 136;
		public const int Optional             = 137;
		public const int Or                   = 138;
		public const int OrElse               = 139;
		public const int Overloads            = 140;
		public const int Overridable          = 141;
		public const int Overrides            = 142;
		public const int ParamArray           = 143;
		public const int Preserve             = 144;
		public const int Private              = 145;
		public const int Property             = 146;
		public const int Protected            = 147;
		public const int Public               = 148;
		public const int RaiseEvent           = 149;
		public const int ReadOnly             = 150;
		public const int ReDim                = 151;
		public const int RemoveHandler        = 152;
		public const int Resume               = 153;
		public const int Return               = 154;
		public const int Select               = 155;
		public const int Set                  = 156;
		public const int Shadows              = 157;
		public const int Shared               = 158;
		public const int Short                = 159;
		public const int Single               = 160;
		public const int Static               = 161;
		public const int Step                 = 162;
		public const int Stop                 = 163;
		public const int Strict               = 164;
		public const int String               = 165;
		public const int Structure            = 166;
		public const int Sub                  = 167;
		public const int SyncLock             = 168;
		public const int Text                 = 169;
		public const int Then                 = 170;
		public const int Throw                = 171;
		public const int To                   = 172;
		public const int True                 = 173;
		public const int Try                  = 174;
		public const int TypeOf               = 175;
		public const int Unicode              = 176;
		public const int Until                = 177;
		public const int Variant              = 178;
		public const int Wend                 = 179;
		public const int When                 = 180;
		public const int While                = 181;
		public const int With                 = 182;
		public const int WithEvents           = 183;
		public const int WriteOnly            = 184;
		public const int Xor                  = 185;
		public const int Continue             = 186;
		public const int Operator             = 187;
		public const int Using                = 188;
		public const int IsNot                = 189;
		public const int SByte                = 190;
		public const int UInteger             = 191;
		public const int ULong                = 192;
		public const int UShort               = 193;
		public const int CSByte               = 194;
		public const int CUShort              = 195;
		public const int CUInt                = 196;
		public const int CULng                = 197;
		public const int Global               = 198;
		public const int TryCast              = 199;
		public const int Of                   = 200;
		public const int Narrowing            = 201;
		public const int Widening             = 202;
		public const int Partial              = 203;
		public const int Custom               = 204;

		public const int MaxToken = 205;
		static BitArray NewSet(params int[] values)
		{
			BitArray bitArray = new BitArray(MaxToken);
			foreach (int val in values) {
			bitArray[val] = true;
			}
			return bitArray;
		}
		public static BitArray Null = NewSet(Nothing);
		public static BitArray BlockSucc = NewSet(Case, Catch, Else, ElseIf, End, Finally, Loop, Next);
		public static BitArray Unreserved = NewSet(Text, Binary, Compare, Assembly, Ansi, Auto, Preserve, Unicode, Until, Explicit, Off);

		static string[] tokenList = new string[] {
			// ----- terminal classes -----
			"<EOF>",
			"<EOL>",
			"<Identifier>",
			"<LiteralString>",
			"<LiteralCharacter>",
			"<LiteralInteger>",
			"<LiteralDouble>",
			"<LiteralSingle>",
			"<LiteralDecimal>",
			"<LiteralDate>",
			// ----- special character -----
			".",
			"=",
			",",
			":",
			"+",
			"-",
			"*",
			"/",
			"\\",
			"&",
			"^",
			"?",
			"{",
			"}",
			"(",
			")",
			">",
			"<",
			"<>",
			">=",
			"<=",
			"<<",
			">>",
			"+=",
			"^=",
			"-=",
			"*=",
			"/=",
			"\\=",
			"<<=",
			">>=",
			"&=",
			// ----- keywords -----
			"AddHandler",
			"AddressOf",
			"Alias",
			"And",
			"AndAlso",
			"Ansi",
			"As",
			"Assembly",
			"Auto",
			"Binary",
			"Boolean",
			"ByRef",
			"Byte",
			"ByVal",
			"Call",
			"Case",
			"Catch",
			"CBool",
			"CByte",
			"CChar",
			"CDate",
			"CDbl",
			"CDec",
			"Char",
			"CInt",
			"Class",
			"CLng",
			"CObj",
			"Compare",
			"Const",
			"CShort",
			"CSng",
			"CStr",
			"CType",
			"Date",
			"Decimal",
			"Declare",
			"Default",
			"Delegate",
			"Dim",
			"DirectCast",
			"Do",
			"Double",
			"Each",
			"Else",
			"ElseIf",
			"End",
			"EndIf",
			"Enum",
			"Erase",
			"Error",
			"Event",
			"Exit",
			"Explicit",
			"False",
			"Finally",
			"For",
			"Friend",
			"Function",
			"Get",
			"GetType",
			"GoSub",
			"GoTo",
			"Handles",
			"If",
			"Implements",
			"Imports",
			"In",
			"Inherits",
			"Integer",
			"Interface",
			"Is",
			"Let",
			"Lib",
			"Like",
			"Long",
			"Loop",
			"Me",
			"Mod",
			"Module",
			"MustInherit",
			"MustOverride",
			"MyBase",
			"MyClass",
			"Namespace",
			"New",
			"Next",
			"Not",
			"Nothing",
			"NotInheritable",
			"NotOverridable",
			"Object",
			"Off",
			"On",
			"Option",
			"Optional",
			"Or",
			"OrElse",
			"Overloads",
			"Overridable",
			"Overrides",
			"ParamArray",
			"Preserve",
			"Private",
			"Property",
			"Protected",
			"Public",
			"RaiseEvent",
			"ReadOnly",
			"ReDim",
			"RemoveHandler",
			"Resume",
			"Return",
			"Select",
			"Set",
			"Shadows",
			"Shared",
			"Short",
			"Single",
			"Static",
			"Step",
			"Stop",
			"Strict",
			"String",
			"Structure",
			"Sub",
			"SyncLock",
			"Text",
			"Then",
			"Throw",
			"To",
			"True",
			"Try",
			"TypeOf",
			"Unicode",
			"Until",
			"Variant",
			"Wend",
			"When",
			"While",
			"With",
			"WithEvents",
			"WriteOnly",
			"Xor",
			"Continue",
			"Operator",
			"Using",
			"IsNot",
			"SByte",
			"UInteger",
			"ULong",
			"UShort",
			"CSByte",
			"CUShort",
			"CUInt",
			"CULng",
			"Global",
			"TryCast",
			"Of",
			"Narrowing",
			"Widening",
			"Partial",
			"Custom",
		};
		public static string GetTokenString(int token)
		{
			if (token >= 0 && token < tokenList.Length) {
				return tokenList[token];
			}
			throw new System.NotSupportedException("Unknown token:" + token);
		}
	}
}
