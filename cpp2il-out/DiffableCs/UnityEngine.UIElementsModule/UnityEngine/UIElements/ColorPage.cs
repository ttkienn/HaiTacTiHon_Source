namespace UnityEngine.UIElements;

internal struct ColorPage
{
	public bool isValid; //Field offset: 0x0
	public Color32 pageAndID; //Field offset: 0x4

	public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc) { }

	public NativeColorPage ToNativeColorPage() { }

}

