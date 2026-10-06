namespace UnityEngine.Windows.Speech;

public abstract class PhraseRecognizer
{
	internal sealed class PhraseRecognizedDelegate : MulticastDelegate
	{

		public PhraseRecognizedDelegate(object object, IntPtr method) { }

		public override void Invoke(PhraseRecognizedEventArgs args) { }

	}

	protected IntPtr m_Recognizer; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PhraseRecognizedDelegate OnPhraseRecognized; //Field offset: 0x18

	[RequiredByNativeCode]
	private void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[RequiredByNativeCode]
	private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }

}

