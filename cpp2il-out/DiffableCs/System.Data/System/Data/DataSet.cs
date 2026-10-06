namespace System.Data;

[DefaultProperty("DataSetName")]
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[XmlRoot("DataSet")]
[XmlSchemaProvider("GetDataSetSchema")]
public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private static XmlSchemaComplexType s_schemaTypeForWSDL; //Field offset: 0x8
	private DataViewManager _defaultViewManager; //Field offset: 0x20
	private readonly DataTableCollection _tableCollection; //Field offset: 0x28
	private readonly DataRelationCollection _relationCollection; //Field offset: 0x30
	internal PropertyCollection _extendedProperties; //Field offset: 0x38
	private string _dataSetName; //Field offset: 0x40
	private string _datasetPrefix; //Field offset: 0x48
	internal string _namespaceURI; //Field offset: 0x50
	private bool _enforceConstraints; //Field offset: 0x58
	private bool _caseSensitive; //Field offset: 0x59
	private CultureInfo _culture; //Field offset: 0x60
	private bool _cultureUserSet; //Field offset: 0x68
	internal bool _fInReadXml; //Field offset: 0x69
	internal bool _fInLoadDiffgram; //Field offset: 0x6A
	internal bool _fTopLevelTable; //Field offset: 0x6B
	internal bool _fInitInProgress; //Field offset: 0x6C
	internal bool _fEnableCascading; //Field offset: 0x6D
	internal bool _fIsSchemaLoading; //Field offset: 0x6E
	internal string _mainTableName; //Field offset: 0x70
	private SerializationFormat _remotingFormat; //Field offset: 0x78
	private object _defaultViewManagerLock; //Field offset: 0x80
	private readonly int _objectID; //Field offset: 0x88
	internal bool _useDataSetSchemaOnly; //Field offset: 0x8C
	internal bool _udtIsWrapped; //Field offset: 0x8D
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; //Field offset: 0x90
	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed; //Field offset: 0x98
	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated; //Field offset: 0xA0
	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled; //Field offset: 0xA8

	[DefaultValue(False)]
	public bool CaseSensitive
	{
		 get { } //Length: 5
		 set { } //Length: 657
	}

	[DefaultValue(null)]
	public string DataSetName
	{
		 get { } //Length: 5
		 set { } //Length: 357
	}

	[DefaultValue(True)]
	public bool EnforceConstraints
	{
		 get { } //Length: 5
		 set { } //Length: 310
	}

	[Browsable(False)]
	public PropertyCollection ExtendedProperties
	{
		 get { } //Length: 106
	}

	public CultureInfo Locale
	{
		 get { } //Length: 5
		 set { } //Length: 348
	}

	internal string MainTableName
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	[DefaultValue(null)]
	public string Namespace
	{
		 get { } //Length: 5
		 set { } //Length: 971
	}

	internal int ObjectID
	{
		internal get { } //Length: 7
	}

	[DefaultValue(null)]
	public string Prefix
	{
		 get { } //Length: 5
		 set { } //Length: 288
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public DataRelationCollection Relations
	{
		 get { } //Length: 5
	}

	[DefaultValue(SerializationFormat::Xml (0))]
	public SerializationFormat RemotingFormat
	{
		 get { } //Length: 4
		 set { } //Length: 187
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		 get { } //Length: 6
	}

	[Browsable(False)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility::Hidden (0))]
	public virtual ISite Site
	{
		 get { } //Length: 5
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility::Content (2))]
	public DataTableCollection Tables
	{
		 get { } //Length: 5
	}

	public DataSet() { }

	public DataSet(string dataSetName) { }

	protected DataSet(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	protected DataSet(SerializationInfo info, StreamingContext context) { }

	public void Clear() { }

	public override DataSet Clone() { }

	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	internal void EnableConstraints() { }

	internal int EstimatedXmlStringSize() { }

	internal void FailedEnableConstraints() { }

	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	public bool get_CaseSensitive() { }

	public string get_DataSetName() { }

	public bool get_EnforceConstraints() { }

	public PropertyCollection get_ExtendedProperties() { }

	public CultureInfo get_Locale() { }

	internal string get_MainTableName() { }

	public string get_Namespace() { }

	internal int get_ObjectID() { }

	public string get_Prefix() { }

	public DataRelationCollection get_Relations() { }

	public SerializationFormat get_RemotingFormat() { }

	public override SchemaSerializationMode get_SchemaSerializationMode() { }

	public virtual ISite get_Site() { }

	public DataTableCollection get_Tables() { }

	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal string GetRemotingDiffGram(DataTable table) { }

	internal string GetXmlSchemaForRemoting(DataTable table) { }

	internal void InferSchema(XmlDocument xdoc, String[] excludedNamespaces, XmlReadMode mode) { }

	protected override void InitializeDerivedDataSet() { }

	private bool IsEmpty() { }

	public void Merge(DataSet dataSet) { }

	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	private static void MoveToElement(XmlReader reader) { }

	internal bool MoveToElement(XmlReader reader, int depth) { }

	internal void OnClearFunctionCalled(DataTable table) { }

	internal void OnDataRowCreated(DataRow row) { }

	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	protected override void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	internal void OnRemovedTable(DataTable table) { }

	protected override void OnRemoveRelation(DataRelation relation) { }

	internal void OnRemoveRelationHack(DataRelation relation) { }

	protected private override void OnRemoveTable(DataTable table) { }

	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	protected private void RaisePropertyChanging(string name) { }

	internal void ReadEndElement(XmlReader reader) { }

	internal void ReadXDRSchema(XmlReader reader) { }

	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	public XmlReadMode ReadXml(XmlReader reader) { }

	private void ReadXmlDiffgram(XmlReader reader) { }

	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	public void ReadXmlSchema(XmlReader reader) { }

	protected override void ReadXmlSerializable(XmlReader reader) { }

	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	public override void Reset() { }

	internal void RestoreEnforceConstraints(bool value) { }

	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	public void set_CaseSensitive(bool value) { }

	public void set_DataSetName(string value) { }

	public void set_EnforceConstraints(bool value) { }

	public void set_Locale(CultureInfo value) { }

	internal void set_MainTableName(string value) { }

	public void set_Namespace(string value) { }

	public void set_Prefix(string value) { }

	public void set_RemotingFormat(SerializationFormat value) { }

	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	internal bool ShouldSerializeLocale() { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	internal DataTable[] TopLevelTables() { }

	internal DataTable[] TopLevelTables(bool forSchema) { }

	internal bool ValidateCaseConstraint() { }

	internal bool ValidateLocaleConstraint() { }

	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, String> multipleTargetConverter) { }

}

