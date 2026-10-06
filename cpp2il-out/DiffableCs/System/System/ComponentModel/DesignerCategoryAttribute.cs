namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = True)]
public sealed class DesignerCategoryAttribute : Attribute
{
	public static readonly DesignerCategoryAttribute Component; //Field offset: 0x0
	public static readonly DesignerCategoryAttribute Default; //Field offset: 0x8
	public static readonly DesignerCategoryAttribute Form; //Field offset: 0x10
	public static readonly DesignerCategoryAttribute Generic; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; //Field offset: 0x10

	public string Category
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual object TypeId
	{
		 get { } //Length: 69
	}

	private static DesignerCategoryAttribute() { }

	public DesignerCategoryAttribute() { }

	public DesignerCategoryAttribute(string category) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_Category() { }

	public virtual object get_TypeId() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

