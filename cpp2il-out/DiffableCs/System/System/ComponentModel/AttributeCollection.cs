namespace System.ComponentModel;

[DefaultMember("Item")]
public class AttributeCollection : ICollection, IEnumerable
{
	private struct AttributeEntry
	{
		public Type type; //Field offset: 0x0
		public int index; //Field offset: 0x8

	}

	public static readonly AttributeCollection Empty; //Field offset: 0x0
	private static Hashtable s_defaultAttributes; //Field offset: 0x8
	private static readonly object s_internalSyncObject; //Field offset: 0x10
	private readonly Attribute[] _attributes; //Field offset: 0x10
	private AttributeEntry[] _foundAttributeTypes; //Field offset: 0x18
	private int _index; //Field offset: 0x20

	protected override Attribute[] Attributes
	{
		 get { } //Length: 5
	}

	public int Count
	{
		 get { } //Length: 41
	}

	public override Attribute Item
	{
		 get { } //Length: 1379
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 41
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 3
	}

	private static AttributeCollection() { }

	public AttributeCollection(Attribute[] attributes) { }

	public bool Contains(Attribute attribute) { }

	public override void CopyTo(Array array, int index) { }

	protected override Attribute[] get_Attributes() { }

	public int get_Count() { }

	public override Attribute get_Item(Type attributeType) { }

	protected Attribute GetDefaultAttribute(Type attributeType) { }

	public IEnumerator GetEnumerator() { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

