namespace System.Text.RegularExpressions;

internal sealed class RegexParser
{
	private static readonly Byte[] s_category; //Field offset: 0x0
	private RegexNode _stack; //Field offset: 0x10
	private RegexNode _group; //Field offset: 0x18
	private RegexNode _alternation; //Field offset: 0x20
	private RegexNode _concatenation; //Field offset: 0x28
	private RegexNode _unit; //Field offset: 0x30
	private string _pattern; //Field offset: 0x38
	private int _currentPos; //Field offset: 0x40
	private CultureInfo _culture; //Field offset: 0x48
	private int _autocap; //Field offset: 0x50
	private int _capcount; //Field offset: 0x54
	private int _captop; //Field offset: 0x58
	private int _capsize; //Field offset: 0x5C
	private Hashtable _caps; //Field offset: 0x60
	private Hashtable _capnames; //Field offset: 0x68
	private Int32[] _capnumlist; //Field offset: 0x70
	private List<String> _capnamelist; //Field offset: 0x78
	private RegexOptions _options; //Field offset: 0x80
	private List<RegexOptions> _optionsStack; //Field offset: 0x88
	private bool _ignoreNextParen; //Field offset: 0x90

	private static RegexParser() { }

	private RegexParser(CultureInfo culture) { }

	private void AddAlternate() { }

	private void AddConcatenate(bool lazy, int min, int max) { }

	private void AddConcatenate() { }

	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	private void AddGroup() { }

	private void AddUnitNode(RegexNode node) { }

	private void AddUnitNotone(char ch) { }

	private void AddUnitOne(char ch) { }

	private void AddUnitSet(string cc) { }

	private void AddUnitType(int type) { }

	private void AssignNameSlots() { }

	private int CaptureSlotFromName(string capname) { }

	private char CharAt(int i) { }

	private int CharsRight() { }

	private void CountCaptures() { }

	private bool EmptyOptionsStack() { }

	private bool EmptyStack() { }

	private static int HexDigit(char ch) { }

	private bool IsCaptureName(string capname) { }

	private bool IsCaptureSlot(int i) { }

	private bool IsOnlyTopOption(RegexOptions option) { }

	private static bool IsQuantifier(char ch) { }

	private static bool IsSpace(char ch) { }

	private static bool IsSpecial(char ch) { }

	private static bool IsStopperX(char ch) { }

	private bool IsTrueQuantifier() { }

	private ArgumentException MakeException(string message) { }

	private void MoveLeft() { }

	private void MoveRight(int i) { }

	private void MoveRight() { }

	private void NoteCaptureName(string name, int pos) { }

	private void NoteCaptureSlot(int i, int pos) { }

	private static RegexOptions OptionFromCode(char ch) { }

	public static RegexTree Parse(string re, RegexOptions op) { }

	private string ParseProperty() { }

	private void PopGroup() { }

	private void PopKeepOptions() { }

	private void PopOptions() { }

	private void PushGroup() { }

	private void PushOptions() { }

	private void Reset(RegexOptions topopts) { }

	private char RightChar(int i) { }

	internal char RightChar() { }

	private char RightCharMoveRight() { }

	private RegexNode ScanBackslash(bool scanOnly) { }

	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	private void ScanBlank() { }

	private string ScanCapname() { }

	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	private char ScanCharEscape() { }

	private char ScanControl() { }

	private int ScanDecimal() { }

	private RegexNode ScanGroupOpen() { }

	private char ScanHex(int c) { }

	private char ScanOctal() { }

	private void ScanOptions() { }

	private RegexNode ScanRegex() { }

	private void SetPattern(string Re) { }

	private void StartGroup(RegexNode openGroup) { }

	private int Textpos() { }

	private void Textto(int pos) { }

	private int TypeFromCode(char ch) { }

	private RegexNode Unit() { }

	private bool UseOptionE() { }

	private bool UseOptionI() { }

	private bool UseOptionM() { }

	private bool UseOptionN() { }

	private bool UseOptionS() { }

	private bool UseOptionX() { }

}

