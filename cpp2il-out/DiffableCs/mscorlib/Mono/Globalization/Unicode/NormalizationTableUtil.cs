namespace Mono.Globalization.Unicode;

internal class NormalizationTableUtil
{
	public static readonly CodePointIndexer Prop; //Field offset: 0x0
	public static readonly CodePointIndexer Map; //Field offset: 0x8
	public static readonly CodePointIndexer Combining; //Field offset: 0x10
	public static readonly CodePointIndexer Composite; //Field offset: 0x18
	public static readonly CodePointIndexer Helper; //Field offset: 0x20

	private static NormalizationTableUtil() { }

	public static int MapIdx(int cp) { }

	public static int PropIdx(int cp) { }

}

