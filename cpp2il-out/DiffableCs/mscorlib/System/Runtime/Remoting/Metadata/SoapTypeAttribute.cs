namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(1052)]
[ComVisible(True)]
public sealed class SoapTypeAttribute : SoapAttribute
{
	private bool _useAttribute; //Field offset: 0x28
	private string _xmlElementName; //Field offset: 0x30
	private string _xmlNamespace; //Field offset: 0x38
	private string _xmlTypeName; //Field offset: 0x40
	private string _xmlTypeNamespace; //Field offset: 0x48
	private bool _isType; //Field offset: 0x50
	private bool _isElement; //Field offset: 0x51

	internal bool IsInteropXmlElement
	{
		internal get { } //Length: 5
	}

	internal bool IsInteropXmlType
	{
		internal get { } //Length: 5
	}

	public virtual bool UseAttribute
	{
		 get { } //Length: 5
	}

	public string XmlElementName
	{
		 get { } //Length: 5
	}

	public virtual string XmlNamespace
	{
		 get { } //Length: 5
	}

	public string XmlTypeName
	{
		 get { } //Length: 5
	}

	public string XmlTypeNamespace
	{
		 get { } //Length: 5
	}

	public SoapTypeAttribute() { }

	internal bool get_IsInteropXmlElement() { }

	internal bool get_IsInteropXmlType() { }

	public virtual bool get_UseAttribute() { }

	public string get_XmlElementName() { }

	public virtual string get_XmlNamespace() { }

	public string get_XmlTypeName() { }

	public string get_XmlTypeNamespace() { }

	internal virtual void SetReflectionObject(object reflectionObject) { }

}

