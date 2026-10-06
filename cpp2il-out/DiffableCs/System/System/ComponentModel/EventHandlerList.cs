namespace System.ComponentModel;

[DefaultMember("Item")]
public sealed class EventHandlerList
{
	private sealed class ListEntry
	{
		internal ListEntry _next; //Field offset: 0x10
		internal object _key; //Field offset: 0x18
		internal Delegate _handler; //Field offset: 0x20

	}

	private ListEntry _head; //Field offset: 0x10
	private Component _parent; //Field offset: 0x18

	public Delegate Item
	{
		 get { } //Length: 91
	}

	private ListEntry Find(object key) { }

	public Delegate get_Item(object key) { }

}

