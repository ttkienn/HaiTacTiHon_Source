namespace System.ComponentModel;

public class CollectionChangeEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly CollectionChangeAction <Action>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly object <Element>k__BackingField; //Field offset: 0x18

	public override CollectionChangeAction Action
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	public override object Element
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CollectionChangeEventArgs(CollectionChangeAction action, object element) { }

	[CompilerGenerated]
	public override CollectionChangeAction get_Action() { }

	[CompilerGenerated]
	public override object get_Element() { }

}

