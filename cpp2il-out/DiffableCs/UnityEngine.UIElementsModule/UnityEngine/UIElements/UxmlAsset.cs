namespace UnityEngine.UIElements;

internal class UxmlAsset : IUxmlAttributes
{
	[SerializeField]
	private string m_FullTypeName; //Field offset: 0x10
	[SerializeField]
	private int m_Id; //Field offset: 0x18
	[SerializeField]
	private int m_OrderInDocument; //Field offset: 0x1C
	[SerializeField]
	private int m_ParentId; //Field offset: 0x20
	[SerializeField]
	protected List<String> m_Properties; //Field offset: 0x28

	public string fullTypeName
	{
		 get { } //Length: 5
	}

	public int id
	{
		 get { } //Length: 4
	}

	public int orderInDocument
	{
		 get { } //Length: 4
	}

	public int parentId
	{
		 get { } //Length: 4
	}

	public string get_fullTypeName() { }

	public int get_id() { }

	public int get_orderInDocument() { }

	public int get_parentId() { }

	public void SetAttribute(string name, string value) { }

	private void SetOrAddProperty(string propertyName, string propertyValue) { }

	public override bool TryGetAttributeValue(string propertyName, out string value) { }

}

