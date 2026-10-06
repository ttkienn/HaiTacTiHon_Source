namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class ReadOnlyAttribute : Attribute
{
	public static readonly ReadOnlyAttribute Yes; //Field offset: 0x0
	public static readonly ReadOnlyAttribute No; //Field offset: 0x8
	public static readonly ReadOnlyAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x10

	public bool IsReadOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static ReadOnlyAttribute() { }

	public ReadOnlyAttribute(bool isReadOnly) { }

	public virtual bool Equals(object value) { }

	[CompilerGenerated]
	public bool get_IsReadOnly() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

