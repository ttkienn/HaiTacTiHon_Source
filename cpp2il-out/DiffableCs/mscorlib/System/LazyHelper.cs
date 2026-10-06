namespace System;

internal class LazyHelper
{
	internal static readonly LazyHelper NoneViaConstructor; //Field offset: 0x0
	internal static readonly LazyHelper NoneViaFactory; //Field offset: 0x8
	internal static readonly LazyHelper PublicationOnlyViaConstructor; //Field offset: 0x10
	internal static readonly LazyHelper PublicationOnlyViaFactory; //Field offset: 0x18
	internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish; //Field offset: 0x20
	[CompilerGenerated]
	private readonly LazyState <State>k__BackingField; //Field offset: 0x10
	private readonly ExceptionDispatchInfo _exceptionDispatch; //Field offset: 0x18

	internal LazyState State
	{
		[CompilerGenerated]
		internal get { } //Length: 191
	}

	private static LazyHelper() { }

	internal LazyHelper(LazyState state) { }

	internal LazyHelper(LazyThreadSafetyMode mode, Exception exception) { }

	internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	internal static object CreateViaDefaultConstructor(Type type) { }

	[CompilerGenerated]
	internal LazyState get_State() { }

	internal void ThrowException() { }

}

