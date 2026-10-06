namespace Mono;

internal struct SafeStringMarshal : IDisposable
{
	private readonly string str; //Field offset: 0x0
	private IntPtr marshaled_string; //Field offset: 0x8

	public IntPtr Value
	{
		 get { } //Length: 65
	}

	public SafeStringMarshal(string str) { }

	public override void Dispose() { }

	public IntPtr get_Value() { }

	public static void GFree(IntPtr ptr) { }

	public static IntPtr StringToUtf8(string str) { }

	private static IntPtr StringToUtf8_icall(ref string str) { }

}

