namespace System.Text.RegularExpressions;

public class Group : Capture
{
	internal static readonly Group s_emptyGroup; //Field offset: 0x0
	internal readonly Int32[] _caps; //Field offset: 0x20
	internal int _capcount; //Field offset: 0x28
	internal CaptureCollection _capcoll; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x38

	public bool Success
	{
		 get { } //Length: 8
	}

	private static Group() { }

	internal Group(string text, Int32[] caps, int capcount, string name) { }

	internal Group() { }

	public bool get_Success() { }

}

