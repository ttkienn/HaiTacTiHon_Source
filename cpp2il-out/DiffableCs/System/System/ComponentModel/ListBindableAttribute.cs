namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class ListBindableAttribute : Attribute
{
	public static readonly ListBindableAttribute Yes; //Field offset: 0x0
	public static readonly ListBindableAttribute No; //Field offset: 0x8
	public static readonly ListBindableAttribute Default; //Field offset: 0x10
	private bool _isDefault; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <ListBindable>k__BackingField; //Field offset: 0x11

	public bool ListBindable
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static ListBindableAttribute() { }

	public ListBindableAttribute(bool listBindable) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public bool get_ListBindable() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

