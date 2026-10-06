namespace System.Runtime.Remoting.Channels;

internal class CrossAppDomainData
{
	private object _ContextID; //Field offset: 0x10
	private int _DomainID; //Field offset: 0x18
	private string _processGuid; //Field offset: 0x20

	internal int DomainID
	{
		internal get { } //Length: 4
	}

	internal string ProcessID
	{
		internal get { } //Length: 5
	}

	internal CrossAppDomainData(int domainId) { }

	internal int get_DomainID() { }

	internal string get_ProcessID() { }

}

