namespace UnityEngine;

[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[RequiredByNativeCode]
public class AsyncOperation : YieldInstruction
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	private Action<AsyncOperation> m_completeCallback; //Field offset: 0x18

	public event Action<AsyncOperation> completed
	{
		 add { } //Length: 255
		 remove { } //Length: 175
	}

	public bool isDone
	{
		[NativeMethod("IsDone")]
		 get { } //Length: 51
	}

	public AsyncOperation() { }

	public void add_completed(Action<AsyncOperation> value) { }

	protected virtual void Finalize() { }

	[NativeMethod("IsDone")]
	public bool get_isDone() { }

	[NativeMethod(IsThreadSafe = True)]
	[StaticAccessor("AsyncOperationBindings", StaticAccessorType::DoubleColon (2))]
	private static void InternalDestroy(IntPtr ptr) { }

	[RequiredByNativeCode]
	internal void InvokeCompletionEvent() { }

	public void remove_completed(Action<AsyncOperation> value) { }

}

