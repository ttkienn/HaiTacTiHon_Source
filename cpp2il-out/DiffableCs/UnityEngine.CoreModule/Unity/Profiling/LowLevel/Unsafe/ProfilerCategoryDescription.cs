namespace Unity.Profiling.LowLevel.Unsafe;

[IsReadOnly]
public struct ProfilerCategoryDescription
{
	public readonly ushort Id; //Field offset: 0x0
	public readonly ushort Flags; //Field offset: 0x2
	public readonly Color32 Color; //Field offset: 0x4
	private readonly int reserved0; //Field offset: 0x8
	public readonly int NameUtf8Len; //Field offset: 0xC
	public readonly Byte* NameUtf8; //Field offset: 0x10

}

