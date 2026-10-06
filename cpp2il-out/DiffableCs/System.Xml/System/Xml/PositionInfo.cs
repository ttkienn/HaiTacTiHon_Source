namespace System.Xml;

internal class PositionInfo : IXmlLineInfo
{

	public override int LineNumber
	{
		 get { } //Length: 3
	}

	public override int LinePosition
	{
		 get { } //Length: 3
	}

	public PositionInfo() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	public static PositionInfo GetPositionInfo(object o) { }

	public override bool HasLineInfo() { }

}

