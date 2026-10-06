namespace System.Text.RegularExpressions;

public class RegexMatchTimeoutException : TimeoutException, ISerializable
{
	[CompilerGenerated]
	private readonly string <Input>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly TimeSpan <MatchTimeout>k__BackingField; //Field offset: 0xA0

	public string Input
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public TimeSpan MatchTimeout
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public string Pattern
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	public RegexMatchTimeoutException() { }

	protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	public string get_Input() { }

	[CompilerGenerated]
	public TimeSpan get_MatchTimeout() { }

	[CompilerGenerated]
	public string get_Pattern() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

