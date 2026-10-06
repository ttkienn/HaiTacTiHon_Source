namespace System.Runtime.Remoting.Messaging;

internal class CADObjRef
{
	internal ObjRef objref; //Field offset: 0x10
	internal int SourceDomain; //Field offset: 0x18
	internal Byte[] TypeInfo; //Field offset: 0x20

	public CADObjRef(ObjRef o, int sourceDomain) { }

}

