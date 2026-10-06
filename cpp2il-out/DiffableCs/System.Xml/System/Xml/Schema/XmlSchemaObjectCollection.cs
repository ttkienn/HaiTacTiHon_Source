namespace System.Xml.Schema;

[DefaultMember("Item")]
public class XmlSchemaObjectCollection : CollectionBase
{
	private XmlSchemaObject parent; //Field offset: 0x18

	public override XmlSchemaObject Item
	{
		 get { } //Length: 169
		 set { } //Length: 115
	}

	public XmlSchemaObjectCollection() { }

	public int Add(XmlSchemaObject item) { }

	private void Add(XmlSchemaObjectCollection collToAdd) { }

	internal XmlSchemaObjectCollection Clone() { }

	public override XmlSchemaObject get_Item(int index) { }

	public XmlSchemaObjectEnumerator GetEnumerator() { }

	public void Insert(int index, XmlSchemaObject item) { }

	protected virtual void OnClear() { }

	protected virtual void OnInsert(int index, object item) { }

	protected virtual void OnRemove(int index, object item) { }

	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	public void Remove(XmlSchemaObject item) { }

	public override void set_Item(int index, XmlSchemaObject value) { }

}

