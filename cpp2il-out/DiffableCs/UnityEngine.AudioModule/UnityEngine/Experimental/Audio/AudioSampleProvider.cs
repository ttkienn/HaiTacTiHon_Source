namespace UnityEngine.Experimental.Audio;

[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType::DoubleColon (2))]
public class AudioSampleProvider
{
	internal sealed class SampleFramesHandler : MulticastDelegate
	{

		public SampleFramesHandler(object object, IntPtr method) { }

		public override void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private SampleFramesHandler sampleFramesAvailable; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private SampleFramesHandler sampleFramesOverflow; //Field offset: 0x18

	[RequiredByNativeCode]
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCode]
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

