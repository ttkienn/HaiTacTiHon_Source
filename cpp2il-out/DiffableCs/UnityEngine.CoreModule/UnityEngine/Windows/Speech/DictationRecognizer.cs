namespace UnityEngine.Windows.Speech;

public sealed class DictationRecognizer
{
	internal sealed class DictationCompletedDelegate : MulticastDelegate
	{

		public DictationCompletedDelegate(object object, IntPtr method) { }

		public override void Invoke(DictationCompletionCause cause) { }

	}

	internal sealed class DictationErrorHandler : MulticastDelegate
	{

		public DictationErrorHandler(object object, IntPtr method) { }

		public override void Invoke(string error, int hresult) { }

	}

	internal sealed class DictationHypothesisDelegate : MulticastDelegate
	{

		public DictationHypothesisDelegate(object object, IntPtr method) { }

		public override void Invoke(string text) { }

	}

	internal sealed class DictationResultDelegate : MulticastDelegate
	{

		public DictationResultDelegate(object object, IntPtr method) { }

		public override void Invoke(string text, ConfidenceLevel confidence) { }

	}

	private IntPtr m_Recognizer; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DictationHypothesisDelegate DictationHypothesis; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DictationResultDelegate DictationResult; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DictationCompletedDelegate DictationComplete; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DictationErrorHandler DictationError; //Field offset: 0x30

	[RequiredByNativeCode]
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[RequiredByNativeCode]
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }

	[RequiredByNativeCode]
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword) { }

	[RequiredByNativeCode]
	private void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence) { }

}

