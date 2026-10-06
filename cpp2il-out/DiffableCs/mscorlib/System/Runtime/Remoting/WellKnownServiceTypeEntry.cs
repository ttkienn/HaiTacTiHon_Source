namespace System.Runtime.Remoting;

[ComVisible(True)]
public class WellKnownServiceTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x20
	private string obj_uri; //Field offset: 0x28
	private WellKnownObjectMode obj_mode; //Field offset: 0x30

	public WellKnownObjectMode Mode
	{
		 get { } //Length: 4
	}

	public Type ObjectType
	{
		 get { } //Length: 5
	}

	public string ObjectUri
	{
		 get { } //Length: 5
	}

	public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	public WellKnownObjectMode get_Mode() { }

	public Type get_ObjectType() { }

	public string get_ObjectUri() { }

	public virtual string ToString() { }

}

