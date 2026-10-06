namespace System.Xml.Schema;

internal abstract class SchemaBuilder
{

	protected SchemaBuilder() { }

	internal abstract void EndChildren() { }

	internal abstract bool IsContentParsed() { }

	internal abstract void ProcessAttribute(string prefix, string name, string ns, string value) { }

	internal abstract void ProcessCData(string value) { }

	internal abstract bool ProcessElement(string prefix, string name, string ns) { }

	internal abstract void ProcessMarkup(XmlNode[] markup) { }

	internal abstract void StartChildren() { }

}

