namespace System.Runtime.Remoting;

internal class ProviderData
{
	internal string Ref; //Field offset: 0x10
	internal string Type; //Field offset: 0x18
	internal string Id; //Field offset: 0x20
	internal Hashtable CustomProperties; //Field offset: 0x28
	internal IList CustomData; //Field offset: 0x30

	public ProviderData() { }

	public void CopyFrom(ProviderData other) { }

}

