namespace System.Xml.Linq;

[XmlSchemaProvider(null, IsAny = True)]
[XmlTypeConvertor("ConvertForAssignment")]
public class XElement : XContainer, IXmlSerializable
{
	[CompilerGenerated]
	private sealed class <GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private XAttribute <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public XElement <>4__this; //Field offset: 0x28
		private XName name; //Field offset: 0x30
		public XName <>3__name; //Field offset: 0x38
		private XAttribute <a>5__2; //Field offset: 0x40

		private override XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetAttributes>d__116(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

		[DebuggerHidden]
		private override XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal XName name; //Field offset: 0x30
	internal XAttribute lastAttr; //Field offset: 0x38

	public bool HasAttributes
	{
		 get { } //Length: 9
	}

	public bool IsEmpty
	{
		 get { } //Length: 9
	}

	public XName Name
	{
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string Value
	{
		 get { } //Length: 283
		 set { } //Length: 124
	}

	public XElement(XName name) { }

	public XElement(XElement other) { }

	public XElement(XStreamingElement other) { }

	internal virtual void AddAttribute(XAttribute a) { }

	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	internal void AppendAttribute(XAttribute a) { }

	internal void AppendAttributeSkipNotify(XAttribute a) { }

	public XAttribute Attribute(XName name) { }

	public IEnumerable<XAttribute> Attributes() { }

	internal virtual XNode CloneNode() { }

	public bool get_HasAttributes() { }

	public bool get_IsEmpty() { }

	public XName get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_Value() { }

	[IteratorStateMachine(typeof(<GetAttributes>d__116))]
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	public string GetPrefixOfNamespace(XNamespace ns) { }

	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	public void set_Value(string value) { }

	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	internal virtual void ValidateNode(XNode node, XNode previous) { }

	public virtual void WriteTo(XmlWriter writer) { }

}

