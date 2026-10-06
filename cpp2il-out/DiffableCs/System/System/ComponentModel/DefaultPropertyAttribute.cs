namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4))]
public sealed class DefaultPropertyAttribute : Attribute
{
	public static readonly DefaultPropertyAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x10

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static DefaultPropertyAttribute() { }

	public DefaultPropertyAttribute(string name) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Name() { }

	public virtual int GetHashCode() { }

}

