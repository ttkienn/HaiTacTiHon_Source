namespace System.Runtime.Remoting.Proxies;

internal class TransparentProxy
{
	public RealProxy _rp; //Field offset: 0x10
	private RuntimeRemoteClassHandle _class; //Field offset: 0x18
	private bool _custom_type_info; //Field offset: 0x20

	private bool IsContextBoundObject
	{
		private get { } //Length: 190
	}

	private Context TargetContext
	{
		private get { } //Length: 27
	}

	public TransparentProxy() { }

	private bool get_IsContextBoundObject() { }

	private Context get_TargetContext() { }

	internal RuntimeType GetProxyType() { }

	private bool InCurrentContext() { }

	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

}

