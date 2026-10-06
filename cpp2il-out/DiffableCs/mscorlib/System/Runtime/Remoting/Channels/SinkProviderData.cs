namespace System.Runtime.Remoting.Channels;

[ComVisible(True)]
public class SinkProviderData
{
	private string sinkName; //Field offset: 0x10
	private ArrayList children; //Field offset: 0x18
	private Hashtable properties; //Field offset: 0x20

	public IList Children
	{
		 get { } //Length: 5
	}

	public IDictionary Properties
	{
		 get { } //Length: 5
	}

	public SinkProviderData(string name) { }

	public IList get_Children() { }

	public IDictionary get_Properties() { }

}

