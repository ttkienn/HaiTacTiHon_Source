namespace System.Runtime.Remoting;

[ComVisible(True)]
public class ActivatedServiceTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x20

	public Type ObjectType
	{
		 get { } //Length: 5
	}

	public ActivatedServiceTypeEntry(string typeName, string assemblyName) { }

	public Type get_ObjectType() { }

	public virtual string ToString() { }

}

