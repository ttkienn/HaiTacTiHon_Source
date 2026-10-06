namespace Mono;

[DefaultMember("Item")]
internal struct RuntimeGPtrArrayHandle
{
	private GPtrArray* value; //Field offset: 0x0

	internal IntPtr Item
	{
		internal get { } //Length: 8
	}

	internal int Length
	{
		internal get { } //Length: 25
	}

	internal RuntimeGPtrArrayHandle(IntPtr ptr) { }

	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

	internal IntPtr get_Item(int i) { }

	internal int get_Length() { }

	private static void GPtrArrayFree(GPtrArray* value) { }

	internal IntPtr Lookup(int i) { }

}

