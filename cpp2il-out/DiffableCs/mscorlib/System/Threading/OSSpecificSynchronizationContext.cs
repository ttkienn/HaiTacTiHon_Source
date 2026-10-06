namespace System.Threading;

internal class OSSpecificSynchronizationContext : SynchronizationContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static CreateValueCallback<Object, OSSpecificSynchronizationContext> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }

	}

	private class InvocationContext
	{
		private SendOrPostCallback m_Delegate; //Field offset: 0x10
		private object m_State; //Field offset: 0x18

		public InvocationContext(SendOrPostCallback d, object state) { }

		public void Invoke() { }

	}

	private sealed class InvocationEntryDelegate : MulticastDelegate
	{

		public InvocationEntryDelegate(object object, IntPtr method) { }

		public override void Invoke(IntPtr arg) { }

	}

	private static readonly ConditionalWeakTable<Object, OSSpecificSynchronizationContext> s_ContextCache; //Field offset: 0x0
	private object m_OSSynchronizationContext; //Field offset: 0x18

	private static OSSpecificSynchronizationContext() { }

	private OSSpecificSynchronizationContext(object osContext) { }

	public virtual SynchronizationContext CreateCopy() { }

	public static OSSpecificSynchronizationContext Get() { }

	private static object GetOSContext() { }

	[MonoPInvokeCallback(typeof(InvocationEntryDelegate))]
	private static void InvocationEntry(IntPtr arg) { }

	public virtual void Post(SendOrPostCallback d, object state) { }

	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	public virtual void Send(SendOrPostCallback d, object state) { }

}

