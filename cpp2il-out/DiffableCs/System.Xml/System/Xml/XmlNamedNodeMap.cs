namespace System.Xml;

public class XmlNamedNodeMap : IEnumerable
{
	[DefaultMember("Item")]
	public struct SmallXmlNodeList
	{
		private class SingleObjectEnumerator : IEnumerator
		{
			private object loneValue; //Field offset: 0x10
			private int position; //Field offset: 0x18

			public override object Current
			{
				 get { } //Length: 85
			}

			public SingleObjectEnumerator(object value) { }

			public override object get_Current() { }

			public override bool MoveNext() { }

			public override void Reset() { }

		}

		private object field; //Field offset: 0x0

		public int Count
		{
			 get { } //Length: 152
		}

		public object Item
		{
			 get { } //Length: 309
		}

		public void Add(object value) { }

		public int get_Count() { }

		public object get_Item(int index) { }

		public IEnumerator GetEnumerator() { }

		public void Insert(int index, object value) { }

		public void RemoveAt(int index) { }

	}

	internal XmlNode parent; //Field offset: 0x10
	internal SmallXmlNodeList nodes; //Field offset: 0x18

	public override int Count
	{
		 get { } //Length: 11
	}

	internal XmlNamedNodeMap(XmlNode parent) { }

	internal override XmlNode AddNode(XmlNode node) { }

	internal override XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	internal int FindNodeOffset(string name) { }

	internal int FindNodeOffset(string localName, string namespaceURI) { }

	public override int get_Count() { }

	public override IEnumerator GetEnumerator() { }

	public override XmlNode GetNamedItem(string name) { }

	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	internal override XmlNode RemoveNodeAt(int i) { }

	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	public override XmlNode SetNamedItem(XmlNode node) { }

}

