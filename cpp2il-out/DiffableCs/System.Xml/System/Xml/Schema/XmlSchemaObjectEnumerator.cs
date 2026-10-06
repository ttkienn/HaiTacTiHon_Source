namespace System.Xml.Schema;

public class XmlSchemaObjectEnumerator : IEnumerator
{
	private IEnumerator enumerator; //Field offset: 0x10

	public XmlSchemaObject Current
	{
		 get { } //Length: 149
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 73
	}

	internal XmlSchemaObjectEnumerator(IEnumerator enumerator) { }

	public XmlSchemaObject get_Current() { }

	public bool MoveNext() { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override bool System.Collections.IEnumerator.MoveNext() { }

	private override void System.Collections.IEnumerator.Reset() { }

}

