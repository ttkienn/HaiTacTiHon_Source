namespace System.Text.RegularExpressions;

internal sealed class RegexCode
{
	public const int Onerep = 0; //Field offset: 0x0
	public const int Nullcount = 26; //Field offset: 0x0
	public const int Setcount = 27; //Field offset: 0x0
	public const int Lazybranchcount = 29; //Field offset: 0x0
	public const int Nullmark = 30; //Field offset: 0x0
	public const int Setmark = 31; //Field offset: 0x0
	public const int Capturemark = 32; //Field offset: 0x0
	public const int Getmark = 33; //Field offset: 0x0
	public const int Setjump = 34; //Field offset: 0x0
	public const int Backjump = 35; //Field offset: 0x0
	public const int Forejump = 36; //Field offset: 0x0
	public const int Testref = 37; //Field offset: 0x0
	public const int Goto = 38; //Field offset: 0x0
	public const int Prune = 39; //Field offset: 0x0
	public const int Stop = 40; //Field offset: 0x0
	public const int ECMABoundary = 41; //Field offset: 0x0
	public const int NonECMABoundary = 42; //Field offset: 0x0
	public const int Mask = 63; //Field offset: 0x0
	public const int Rtl = 64; //Field offset: 0x0
	public const int Back = 128; //Field offset: 0x0
	public const int Back2 = 256; //Field offset: 0x0
	public const int Ci = 512; //Field offset: 0x0
	public const int Lazybranchmark = 25; //Field offset: 0x0
	public const int Branchmark = 24; //Field offset: 0x0
	public const int Branchcount = 28; //Field offset: 0x0
	public const int Nothing = 22; //Field offset: 0x0
	public const int Notonerep = 1; //Field offset: 0x0
	public const int Setrep = 2; //Field offset: 0x0
	public const int Oneloop = 3; //Field offset: 0x0
	public const int Notoneloop = 4; //Field offset: 0x0
	public const int Setloop = 5; //Field offset: 0x0
	public const int Onelazy = 6; //Field offset: 0x0
	public const int Notonelazy = 7; //Field offset: 0x0
	public const int Lazybranch = 23; //Field offset: 0x0
	public const int One = 9; //Field offset: 0x0
	public const int Notone = 10; //Field offset: 0x0
	public const int Set = 11; //Field offset: 0x0
	public const int Setlazy = 8; //Field offset: 0x0
	public const int Ref = 13; //Field offset: 0x0
	public const int Multi = 12; //Field offset: 0x0
	public const int EndZ = 20; //Field offset: 0x0
	public const int Start = 19; //Field offset: 0x0
	public const int Beginning = 18; //Field offset: 0x0
	public const int End = 21; //Field offset: 0x0
	public const int Boundary = 16; //Field offset: 0x0
	public const int Eol = 15; //Field offset: 0x0
	public const int Bol = 14; //Field offset: 0x0
	public const int Nonboundary = 17; //Field offset: 0x0
	public readonly Int32[] Codes; //Field offset: 0x10
	public readonly String[] Strings; //Field offset: 0x18
	public readonly int TrackCount; //Field offset: 0x20
	public readonly Hashtable Caps; //Field offset: 0x28
	public readonly int CapSize; //Field offset: 0x30
	public readonly Nullable<RegexPrefix> FCPrefix; //Field offset: 0x38
	public readonly RegexBoyerMoore BMPrefix; //Field offset: 0x50
	public readonly int Anchors; //Field offset: 0x58
	public readonly bool RightToLeft; //Field offset: 0x5C

	public RegexCode(Int32[] codes, List<String> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, Nullable<RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	public static bool OpcodeBacktracks(int Op) { }

}

