namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class RefreshPropertiesAttribute : Attribute
{
	public static readonly RefreshPropertiesAttribute All; //Field offset: 0x0
	public static readonly RefreshPropertiesAttribute Repaint; //Field offset: 0x8
	public static readonly RefreshPropertiesAttribute Default; //Field offset: 0x10
	private RefreshProperties refresh; //Field offset: 0x10

	public RefreshProperties RefreshProperties
	{
		 get { } //Length: 191
	}

	private static RefreshPropertiesAttribute() { }

	public RefreshPropertiesAttribute(RefreshProperties refresh) { }

	public virtual bool Equals(object value) { }

	public RefreshProperties get_RefreshProperties() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

