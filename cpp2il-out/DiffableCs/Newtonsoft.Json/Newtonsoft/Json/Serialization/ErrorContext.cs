namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class ErrorContext
{
	[CompilerGenerated]
	private bool <Traced>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Exception <Error>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <OriginalObject>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <Member>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <Handled>k__BackingField; //Field offset: 0x38

	public Exception Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool Handled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(2)]
	public object Member
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public object OriginalObject
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	public string Path
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal bool Traced
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal ErrorContext(object originalObject, object member, string path, Exception error) { }

	[CompilerGenerated]
	public Exception get_Error() { }

	[CompilerGenerated]
	public bool get_Handled() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public object get_Member() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public object get_OriginalObject() { }

	[CompilerGenerated]
	public string get_Path() { }

	[CompilerGenerated]
	internal bool get_Traced() { }

	[CompilerGenerated]
	public void set_Handled(bool value) { }

	[CompilerGenerated]
	internal void set_Traced(bool value) { }

}

