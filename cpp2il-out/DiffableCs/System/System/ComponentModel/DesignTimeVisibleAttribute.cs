namespace System.ComponentModel;

[AttributeUsage(1028)]
public sealed class DesignTimeVisibleAttribute : Attribute
{
	public static readonly DesignTimeVisibleAttribute Yes; //Field offset: 0x0
	public static readonly DesignTimeVisibleAttribute No; //Field offset: 0x8
	public static readonly DesignTimeVisibleAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <Visible>k__BackingField; //Field offset: 0x10

	public bool Visible
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static DesignTimeVisibleAttribute() { }

	public DesignTimeVisibleAttribute(bool visible) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public bool get_Visible() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

