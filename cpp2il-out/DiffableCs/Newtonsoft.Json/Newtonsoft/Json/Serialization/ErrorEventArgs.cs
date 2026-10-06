namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class ErrorEventArgs : EventArgs
{
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <CurrentObject>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ErrorContext <ErrorContext>k__BackingField; //Field offset: 0x18

	[Nullable(2)]
	public object CurrentObject
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
	}

	public ErrorContext ErrorContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ErrorEventArgs(object currentObject, ErrorContext errorContext) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public object get_CurrentObject() { }

	[CompilerGenerated]
	public ErrorContext get_ErrorContext() { }

}

