namespace System.Xml.Linq;

public abstract class XNode : XObject
{
	internal XNode next; //Field offset: 0x20

	internal XNode() { }

	internal override void AppendText(StringBuilder sb) { }

	internal abstract XNode CloneNode() { }

	private string GetXmlString(SaveOptions o) { }

	public void Remove() { }

	public virtual string ToString() { }

	public abstract void WriteTo(XmlWriter writer) { }

}

