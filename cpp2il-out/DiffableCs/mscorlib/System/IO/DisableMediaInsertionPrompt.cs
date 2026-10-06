namespace System.IO;

internal struct DisableMediaInsertionPrompt : IDisposable
{
	private static bool useUWPFallback; //Field offset: 0x0
	private bool _disableSuccess; //Field offset: 0x0
	private uint _oldMode; //Field offset: 0x4

	public static DisableMediaInsertionPrompt Create() { }

	public override void Dispose() { }

}

