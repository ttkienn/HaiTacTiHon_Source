namespace UnityEngine;

[DefaultMember("Item")]
[UsedByNativeCode]
public struct Color32 : IFormattable
{
	[Ignore(DoesNotContributeToSize = True)]
	private int rgba; //Field offset: 0x0
	public byte r; //Field offset: 0x0
	public byte g; //Field offset: 0x1
	public byte b; //Field offset: 0x2
	public byte a; //Field offset: 0x3

	public Color32(byte r, byte g, byte b, byte a) { }

	public static Color32 op_Implicit(Color c) { }

	public static Color op_Implicit(Color32 c) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

