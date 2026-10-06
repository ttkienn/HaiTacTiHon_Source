namespace System.ComponentModel;

[AttributeUsage(6140)]
public sealed class EditorBrowsableAttribute : Attribute
{
	private EditorBrowsableState browsableState; //Field offset: 0x10

	public EditorBrowsableAttribute(EditorBrowsableState state) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

