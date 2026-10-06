namespace System.Data;

internal sealed class ExpressionParser
{
	[IsReadOnly]
	private struct ReservedWords
	{
		internal readonly string _word; //Field offset: 0x0
		internal readonly Tokens _token; //Field offset: 0x8
		internal readonly int _op; //Field offset: 0xC

		internal ReservedWords(string word, Tokens token, int op) { }

	}

	private static readonly ReservedWords[] s_reservedwords; //Field offset: 0x0
	private char _escape; //Field offset: 0x10
	private char _decimalSeparator; //Field offset: 0x12
	private char _listSeparator; //Field offset: 0x14
	private char _exponentL; //Field offset: 0x16
	private char _exponentU; //Field offset: 0x18
	internal Char[] _text; //Field offset: 0x20
	internal int _pos; //Field offset: 0x28
	internal int _start; //Field offset: 0x2C
	internal Tokens _token; //Field offset: 0x30
	internal int _op; //Field offset: 0x34
	internal OperatorInfo[] _ops; //Field offset: 0x38
	internal int _topOperator; //Field offset: 0x40
	internal int _topNode; //Field offset: 0x44
	private readonly DataTable _table; //Field offset: 0x48
	internal ExpressionNode[] _nodeStack; //Field offset: 0x50
	internal int _prevOperand; //Field offset: 0x58
	internal ExpressionNode _expression; //Field offset: 0x60

	private static ExpressionParser() { }

	internal ExpressionParser(DataTable table) { }

	private void BuildExpression(int pri) { }

	internal void CheckToken(Tokens token) { }

	private bool IsAlpha(char ch) { }

	private bool IsAlphaNumeric(char ch) { }

	private bool IsDigit(char ch) { }

	private bool IsWhiteSpace(char ch) { }

	internal void LoadExpression(string data) { }

	private ExpressionNode NodePeek() { }

	private ExpressionNode NodePop() { }

	private void NodePush(ExpressionNode node) { }

	internal ExpressionNode Parse() { }

	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	internal Tokens Scan() { }

	private void ScanBinaryConstant() { }

	private void ScanDate() { }

	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	private void ScanName() { }

	private void ScanNumeric() { }

	private void ScanReserved() { }

	private void ScanString(char escape) { }

	internal void ScanToken(Tokens token) { }

	private void ScanWhite() { }

	internal void StartScan() { }

}

