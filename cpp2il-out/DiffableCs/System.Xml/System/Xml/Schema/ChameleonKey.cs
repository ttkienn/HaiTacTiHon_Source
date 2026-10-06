namespace System.Xml.Schema;

internal class ChameleonKey
{
	internal string targetNS; //Field offset: 0x10
	internal Uri chameleonLocation; //Field offset: 0x18
	internal XmlSchema originalSchema; //Field offset: 0x20
	private int hashCode; //Field offset: 0x28

	public ChameleonKey(string ns, XmlSchema originalSchema) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

