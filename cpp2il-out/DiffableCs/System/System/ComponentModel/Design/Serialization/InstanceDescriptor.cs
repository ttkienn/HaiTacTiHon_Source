namespace System.ComponentModel.Design.Serialization;

public sealed class InstanceDescriptor
{
	[CompilerGenerated]
	private readonly ICollection <Arguments>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <IsComplete>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly MemberInfo <MemberInfo>k__BackingField; //Field offset: 0x20

	public ICollection Arguments
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MemberInfo MemberInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public InstanceDescriptor(MemberInfo member, ICollection arguments) { }

	public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete) { }

	[CompilerGenerated]
	public ICollection get_Arguments() { }

	[CompilerGenerated]
	public MemberInfo get_MemberInfo() { }

	public object Invoke() { }

}

