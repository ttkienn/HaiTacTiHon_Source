namespace System.Runtime.CompilerServices;

public class CallSite
{
	internal readonly CallSiteBinder _binder; //Field offset: 0x10
	internal bool _match; //Field offset: 0x18

	public CallSiteBinder Binder
	{
		 get { } //Length: 5
	}

	internal CallSite(CallSiteBinder binder) { }

	public CallSiteBinder get_Binder() { }

}

