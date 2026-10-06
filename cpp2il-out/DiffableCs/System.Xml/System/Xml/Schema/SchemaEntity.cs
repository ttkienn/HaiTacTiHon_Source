namespace System.Xml.Schema;

internal sealed class SchemaEntity : IDtdEntityInfo
{
	private XmlQualifiedName qname; //Field offset: 0x10
	private string url; //Field offset: 0x18
	private string pubid; //Field offset: 0x20
	private string text; //Field offset: 0x28
	private XmlQualifiedName ndata; //Field offset: 0x30
	private int lineNumber; //Field offset: 0x38
	private int linePosition; //Field offset: 0x3C
	private bool isParameter; //Field offset: 0x40
	private bool isExternal; //Field offset: 0x41
	private bool parsingInProgress; //Field offset: 0x42
	private bool isDeclaredInExternal; //Field offset: 0x43
	private string baseURI; //Field offset: 0x48
	private string declaredURI; //Field offset: 0x50

	internal string BaseURI
	{
		internal get { } //Length: 77
		internal set { } //Length: 13
	}

	internal bool DeclaredInExternal
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal string DeclaredURI
	{
		internal get { } //Length: 77
		internal set { } //Length: 13
	}

	internal bool IsExternal
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal int Line
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal XmlQualifiedName Name
	{
		internal get { } //Length: 5
	}

	internal XmlQualifiedName NData
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal bool ParsingInProgress
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal int Pos
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal string Pubid
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	private override string System.Xml.IDtdEntityInfo.BaseUriString
	{
		private get { } //Length: 77
	}

	private override string System.Xml.IDtdEntityInfo.DeclaredUriString
	{
		private get { } //Length: 77
	}

	private override bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal
	{
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdEntityInfo.IsExternal
	{
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdEntityInfo.IsParameterEntity
	{
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdEntityInfo.IsUnparsedEntity
	{
		private get { } //Length: 32
	}

	private override int System.Xml.IDtdEntityInfo.LineNumber
	{
		private get { } //Length: 4
	}

	private override int System.Xml.IDtdEntityInfo.LinePosition
	{
		private get { } //Length: 4
	}

	private override string System.Xml.IDtdEntityInfo.Name
	{
		private get { } //Length: 27
	}

	private override string System.Xml.IDtdEntityInfo.PublicId
	{
		private get { } //Length: 5
	}

	private override string System.Xml.IDtdEntityInfo.SystemId
	{
		private get { } //Length: 5
	}

	private override string System.Xml.IDtdEntityInfo.Text
	{
		private get { } //Length: 5
	}

	internal string Text
	{
		internal get { } //Length: 5
		internal set { } //Length: 32
	}

	internal string Url
	{
		internal get { } //Length: 5
		internal set { } //Length: 32
	}

	internal SchemaEntity(XmlQualifiedName qname, bool isParameter) { }

	internal string get_BaseURI() { }

	internal bool get_DeclaredInExternal() { }

	internal string get_DeclaredURI() { }

	internal bool get_IsExternal() { }

	internal int get_Line() { }

	internal XmlQualifiedName get_Name() { }

	internal XmlQualifiedName get_NData() { }

	internal bool get_ParsingInProgress() { }

	internal int get_Pos() { }

	internal string get_Pubid() { }

	internal string get_Text() { }

	internal string get_Url() { }

	internal static bool IsPredefinedEntity(string n) { }

	internal void set_BaseURI(string value) { }

	internal void set_DeclaredInExternal(bool value) { }

	internal void set_DeclaredURI(string value) { }

	internal void set_IsExternal(bool value) { }

	internal void set_Line(int value) { }

	internal void set_NData(XmlQualifiedName value) { }

	internal void set_ParsingInProgress(bool value) { }

	internal void set_Pos(int value) { }

	internal void set_Pubid(string value) { }

	internal void set_Text(string value) { }

	internal void set_Url(string value) { }

	private override string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	private override string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	private override bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	private override bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	private override bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	private override bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	private override int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	private override int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	private override string System.Xml.IDtdEntityInfo.get_Name() { }

	private override string System.Xml.IDtdEntityInfo.get_PublicId() { }

	private override string System.Xml.IDtdEntityInfo.get_SystemId() { }

	private override string System.Xml.IDtdEntityInfo.get_Text() { }

}

