namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
public class DebugInfoExpression : Expression
{
	[CompilerGenerated]
	private readonly SymbolDocumentInfo <Document>k__BackingField; //Field offset: 0x10

	public SymbolDocumentInfo Document
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[ExcludeFromCodeCoverage]
	public override int EndLine
	{
		 get { } //Length: 39
	}

	[ExcludeFromCodeCoverage]
	public override bool IsClear
	{
		 get { } //Length: 39
	}

	[ExcludeFromCodeCoverage]
	public override int StartLine
	{
		 get { } //Length: 39
	}

	[CompilerGenerated]
	public SymbolDocumentInfo get_Document() { }

	public override int get_EndLine() { }

	public override bool get_IsClear() { }

	public override int get_StartLine() { }

}

