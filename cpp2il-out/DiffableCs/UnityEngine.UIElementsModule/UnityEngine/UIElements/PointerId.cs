namespace UnityEngine.UIElements;

public static class PointerId
{
	public static readonly int maxPointers; //Field offset: 0x0
	public static readonly int invalidPointerId; //Field offset: 0x4
	public static readonly int mousePointerId; //Field offset: 0x8
	public static readonly int touchPointerIdBase; //Field offset: 0xC
	public static readonly int touchPointerCount; //Field offset: 0x10
	public static readonly int penPointerIdBase; //Field offset: 0x14
	public static readonly int penPointerCount; //Field offset: 0x18
	internal static readonly Int32[] hoveringPointers; //Field offset: 0x20

	private static PointerId() { }

}

