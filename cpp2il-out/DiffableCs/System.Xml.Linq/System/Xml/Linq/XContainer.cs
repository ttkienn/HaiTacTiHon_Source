namespace System.Xml.Linq;

public abstract class XContainer : XNode
{
	[CompilerGenerated]
	private sealed class <Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private XNode <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public XContainer <>4__this; //Field offset: 0x28
		private XNode <n>5__2; //Field offset: 0x30

		private override XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current
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
		public <Nodes>d__18(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

		[DebuggerHidden]
		private override XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class ContentReader
	{
		private readonly NamespaceCache _eCache; //Field offset: 0x10
		private readonly NamespaceCache _aCache; //Field offset: 0x20
		private readonly IXmlLineInfo _lineInfo; //Field offset: 0x30
		private XContainer _currentContainer; //Field offset: 0x38
		private string _baseUri; //Field offset: 0x40

		public ContentReader(XContainer rootContainer) { }

		public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o) { }

		public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

		public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	}

	internal object content; //Field offset: 0x28

	public XNode LastNode
	{
		 get { } //Length: 379
	}

	internal XContainer() { }

	internal XContainer(XContainer other) { }

	public void Add(object content) { }

	internal override void AddAttribute(XAttribute a) { }

	internal override void AddAttributeSkipNotify(XAttribute a) { }

	internal void AddContentSkipNotify(object content) { }

	internal void AddNode(XNode n) { }

	internal void AddNodeSkipNotify(XNode n) { }

	internal void AddString(string s) { }

	internal void AddStringSkipNotify(string s) { }

	internal void AppendNode(XNode n) { }

	internal void AppendNodeSkipNotify(XNode n) { }

	internal virtual void AppendText(StringBuilder sb) { }

	internal void ConvertTextToNode() { }

	public XNode get_LastNode() { }

	internal static string GetStringValue(object value) { }

	[IteratorStateMachine(typeof(<Nodes>d__18))]
	public IEnumerable<XNode> Nodes() { }

	internal void ReadContentFrom(XmlReader r) { }

	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	internal void RemoveNode(XNode n) { }

	public void RemoveNodes() { }

	private void RemoveNodesSkipNotify() { }

	internal override void ValidateNode(XNode node, XNode previous) { }

	internal override void ValidateString(string s) { }

	internal void WriteContentTo(XmlWriter writer) { }

}

