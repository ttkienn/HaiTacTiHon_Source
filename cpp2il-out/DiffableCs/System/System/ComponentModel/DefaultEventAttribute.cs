namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4))]
public sealed class DefaultEventAttribute : Attribute
{
	public static readonly DefaultEventAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x10

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static DefaultEventAttribute() { }

	public DefaultEventAttribute(string name) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Name() { }

	public virtual int GetHashCode() { }

}

