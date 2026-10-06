namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public class CategoryAttribute : Attribute
{
	private static CategoryAttribute defAttr; //Field offset: 0x0
	private bool localized; //Field offset: 0x10
	private string categoryValue; //Field offset: 0x18

	public string Category
	{
		 get { } //Length: 83
	}

	public static CategoryAttribute Default
	{
		 get { } //Length: 229
	}

	public CategoryAttribute() { }

	public CategoryAttribute(string category) { }

	public virtual bool Equals(object obj) { }

	public string get_Category() { }

	public static CategoryAttribute get_Default() { }

	public virtual int GetHashCode() { }

	protected override string GetLocalizedString(string value) { }

	public virtual bool IsDefaultAttribute() { }

}

