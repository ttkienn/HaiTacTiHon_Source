namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class DesignOnlyAttribute : Attribute
{
	public static readonly DesignOnlyAttribute Yes; //Field offset: 0x0
	public static readonly DesignOnlyAttribute No; //Field offset: 0x8
	public static readonly DesignOnlyAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <IsDesignOnly>k__BackingField; //Field offset: 0x10

	public bool IsDesignOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static DesignOnlyAttribute() { }

	public DesignOnlyAttribute(bool isDesignOnly) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public bool get_IsDesignOnly() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

