namespace Mono;

[DefaultMember("Item")]
internal struct SafeGPtrArrayHandle : IDisposable
{
	private RuntimeGPtrArrayHandle handle; //Field offset: 0x0

	internal IntPtr Item
	{
		internal get { } //Length: 8
	}

	internal int Length
	{
		internal get { } //Length: 25
	}

	internal SafeGPtrArrayHandle(IntPtr ptr) { }

	public override void Dispose() { }

	internal IntPtr get_Item(int i) { }

	internal int get_Length() { }

}

