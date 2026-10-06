namespace System.Xml.Serialization;

public interface IXmlSerializable
{

	public XmlSchema GetSchema() { }

	public void ReadXml(XmlReader reader) { }

	public void WriteXml(XmlWriter writer) { }

}

