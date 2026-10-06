namespace System.Xml.Schema;

internal class XmlListConverter : XmlBaseConverter
{
	protected XmlValueConverter atomicConverter; //Field offset: 0x28

	protected XmlListConverter(XmlBaseConverter atomicConverter) { }

	protected XmlListConverter(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	protected XmlListConverter(XmlSchemaType schemaType) { }

	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	private bool IsListType(Type type) { }

	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	private List<String> StringAsList(string value) { }

	private T[] ToArray(object list, IXmlNamespaceResolver nsResolver) { }

	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

}

