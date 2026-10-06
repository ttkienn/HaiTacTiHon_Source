namespace System.Xml.Schema;

internal class XmlAnyListConverter : XmlListConverter
{
	public static readonly XmlValueConverter ItemList; //Field offset: 0x0
	public static readonly XmlValueConverter AnyAtomicList; //Field offset: 0x8

	private static XmlAnyListConverter() { }

	protected XmlAnyListConverter(XmlBaseConverter atomicConverter) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

