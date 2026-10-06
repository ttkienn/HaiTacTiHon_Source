namespace System.Xml.Linq;

public abstract class XObject : IXmlLineInfo
{
	internal XContainer parent; //Field offset: 0x10
	internal object annotations; //Field offset: 0x18

	public string BaseUri
	{
		 get { } //Length: 126
	}

	internal bool HasBaseUri
	{
		internal get { } //Length: 64
	}

	public abstract XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public XElement Parent
	{
		 get { } //Length: 130
	}

	private override int System.Xml.IXmlLineInfo.LineNumber
	{
		private get { } //Length: 72
	}

	private override int System.Xml.IXmlLineInfo.LinePosition
	{
		private get { } //Length: 72
	}

	internal XObject() { }

	public void AddAnnotation(object annotation) { }

	public T Annotation() { }

	private object AnnotationForSealedType(Type type) { }

	public string get_BaseUri() { }

	internal bool get_HasBaseUri() { }

	public abstract XmlNodeType get_NodeType() { }

	public XElement get_Parent() { }

	internal SaveOptions GetSaveOptionsFromAnnotations() { }

	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	internal void SetBaseUri(string baseUri) { }

	internal void SetLineInfo(int lineNumber, int linePosition) { }

	internal bool SkipNotify() { }

	private override int System.Xml.IXmlLineInfo.get_LineNumber() { }

	private override int System.Xml.IXmlLineInfo.get_LinePosition() { }

	private override bool System.Xml.IXmlLineInfo.HasLineInfo() { }

}

