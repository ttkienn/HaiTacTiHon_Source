namespace UnityEngine.Windows.Speech;

public static class PhraseRecognitionSystem
{
	internal sealed class ErrorDelegate : MulticastDelegate
	{

		public ErrorDelegate(object object, IntPtr method) { }

		public override void Invoke(SpeechError errorCode) { }

	}

	internal sealed class StatusDelegate : MulticastDelegate
	{

		public StatusDelegate(object object, IntPtr method) { }

		public override void Invoke(SpeechSystemStatus status) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ErrorDelegate OnError; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static StatusDelegate OnStatusChanged; //Field offset: 0x8

	[RequiredByNativeCode]
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCode]
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }

}

