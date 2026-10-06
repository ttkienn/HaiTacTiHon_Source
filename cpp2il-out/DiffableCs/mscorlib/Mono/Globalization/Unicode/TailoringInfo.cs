namespace Mono.Globalization.Unicode;

internal class TailoringInfo
{
	public readonly int LCID; //Field offset: 0x10
	public readonly int TailoringIndex; //Field offset: 0x14
	public readonly int TailoringCount; //Field offset: 0x18
	public readonly bool FrenchSort; //Field offset: 0x1C

	public TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort) { }

}

