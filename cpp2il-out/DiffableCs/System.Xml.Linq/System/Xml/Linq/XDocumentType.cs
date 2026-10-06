namespace System.Xml.Linq;

public class XDocumentType : XNode
{
	private string _name; //Field offset: 0x28
	private string _publicId; //Field offset: 0x30
	private string _systemId; //Field offset: 0x38
	private string _internalSubset; //Field offset: 0x40

	public string InternalSubset
	{
		 get { } //Length: 5
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string PublicId
	{
		 get { } //Length: 5
	}

	public string SystemId
	{
		 get { } //Length: 5
	}

	public XDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	public XDocumentType(XDocumentType other) { }

	internal virtual XNode CloneNode() { }

	public string get_InternalSubset() { }

	public string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_PublicId() { }

	public string get_SystemId() { }

	public virtual void WriteTo(XmlWriter writer) { }

}

