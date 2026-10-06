namespace System;

[ComVisible(True)]
public abstract class MarshalByRefObject
{
	private object _identity; //Field offset: 0x10

	internal ServerIdentity ObjectIdentity
	{
		internal get { } //Length: 62
		internal set { } //Length: 62
	}

	protected MarshalByRefObject() { }

	public override ObjRef CreateObjRef(Type requestedType) { }

	internal ServerIdentity get_ObjectIdentity() { }

	public override object InitializeLifetimeService() { }

	internal void set_ObjectIdentity(ServerIdentity value) { }

}

