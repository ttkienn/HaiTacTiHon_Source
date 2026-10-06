namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioClip : object
{
	internal sealed class PCMReaderCallback : MulticastDelegate
	{

		public PCMReaderCallback(object object, IntPtr method) { }

		public override void Invoke(Single[] data) { }

	}

	internal sealed class PCMSetPositionCallback : MulticastDelegate
	{

		public PCMSetPositionCallback(object object, IntPtr method) { }

		public override void Invoke(int position) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMReaderCallback m_PCMReaderCallback; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMSetPositionCallback m_PCMSetPositionCallback; //Field offset: 0x20

	[RequiredByNativeCode]
	private void InvokePCMReaderCallback_Internal(Single[] data) { }

	[RequiredByNativeCode]
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

