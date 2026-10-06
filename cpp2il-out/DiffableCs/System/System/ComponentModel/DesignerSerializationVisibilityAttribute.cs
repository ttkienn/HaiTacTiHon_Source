namespace System.ComponentModel;

[AttributeUsage(960)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	public static readonly DesignerSerializationVisibilityAttribute Content; //Field offset: 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; //Field offset: 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; //Field offset: 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; //Field offset: 0x18
	[CompilerGenerated]
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; //Field offset: 0x10

	public DesignerSerializationVisibility Visibility
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	private static DesignerSerializationVisibilityAttribute() { }

	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public DesignerSerializationVisibility get_Visibility() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

