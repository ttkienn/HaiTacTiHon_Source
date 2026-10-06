namespace UnityEngine;

[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
[RequiredByNativeCode]
[StaticAccessor("GetObjectDispatcher()", StaticAccessorType::Dot (0))]
internal sealed class ObjectDispatcher
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__54_0(Object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, Action<TypeDispatchData> callback) { }

		internal void <.cctor>b__54_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, Action<TransformDispatchData> callback) { }

	}

	private static Action<Object[], IntPtr, IntPtr, Int32, Int32, Action`1<TypeDispatchData>> s_TypeDispatch; //Field offset: 0x0
	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, Int32, Action`1<TransformDispatchData>> s_TransformDispatch; //Field offset: 0x8
	private IntPtr m_Ptr; //Field offset: 0x10

	private static ObjectDispatcher() { }

}

