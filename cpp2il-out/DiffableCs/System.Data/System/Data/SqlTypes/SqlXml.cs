namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public sealed class SqlXml : INullable, IXmlSerializable
{
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; //Field offset: 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; //Field offset: 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; //Field offset: 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; //Field offset: 0x18
	private MethodInfo _createSqlReaderMethodInfo; //Field offset: 0x10
	private bool _fNotNull; //Field offset: 0x18
	private Stream _stream; //Field offset: 0x20
	private bool _firstCreateReader; //Field offset: 0x28

	private static MethodInfo CreateSqlReaderMethodInfo
	{
		private get { } //Length: 479
	}

	public override bool IsNull
	{
		 get { } //Length: 8
	}

	private static SqlXml() { }

	public SqlXml() { }

	public XmlReader CreateReader() { }

	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false) { }

	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	public override bool get_IsNull() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private void SetNull() { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

}

