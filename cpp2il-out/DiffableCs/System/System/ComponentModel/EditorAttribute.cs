namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
public sealed class EditorAttribute : Attribute
{
	private string _typeId; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <EditorBaseTypeName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <EditorTypeName>k__BackingField; //Field offset: 0x20

	public string EditorBaseTypeName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string EditorTypeName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual object TypeId
	{
		 get { } //Length: 157
	}

	public EditorAttribute(string typeName, string baseTypeName) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_EditorBaseTypeName() { }

	[CompilerGenerated]
	public string get_EditorTypeName() { }

	public virtual object get_TypeId() { }

	public virtual int GetHashCode() { }

}

