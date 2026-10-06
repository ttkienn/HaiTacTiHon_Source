namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class BrowsableAttribute : Attribute
{
	public static readonly BrowsableAttribute Yes; //Field offset: 0x0
	public static readonly BrowsableAttribute No; //Field offset: 0x8
	public static readonly BrowsableAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <Browsable>k__BackingField; //Field offset: 0x10

	public bool Browsable
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static BrowsableAttribute() { }

	public BrowsableAttribute(bool browsable) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public bool get_Browsable() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

