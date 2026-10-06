namespace Mono.Globalization.Unicode;

internal class CodePointIndexer
{
	public struct TableRange
	{
		public readonly int Start; //Field offset: 0x0
		public readonly int End; //Field offset: 0x4
		public readonly int Count; //Field offset: 0x8
		public readonly int IndexStart; //Field offset: 0xC
		public readonly int IndexEnd; //Field offset: 0x10

		public TableRange(int start, int end, int indexStart) { }

	}

	private readonly TableRange[] ranges; //Field offset: 0x10
	public readonly int TotalCount; //Field offset: 0x18
	private int defaultIndex; //Field offset: 0x1C
	private int defaultCP; //Field offset: 0x20

	public CodePointIndexer(Int32[] starts, Int32[] ends, int defaultIndex, int defaultCP) { }

	public int ToIndex(int cp) { }

}

