namespace System.ComponentModel;

public class ListChangedEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly ListChangedType <ListChangedType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <NewIndex>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly int <OldIndex>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; //Field offset: 0x20

	public ListChangedType ListChangedType
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	public int NewIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public int OldIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex) { }

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	[CompilerGenerated]
	public ListChangedType get_ListChangedType() { }

	[CompilerGenerated]
	public int get_NewIndex() { }

	[CompilerGenerated]
	public int get_OldIndex() { }

}

