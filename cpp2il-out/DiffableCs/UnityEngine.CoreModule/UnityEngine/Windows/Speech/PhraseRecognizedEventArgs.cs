namespace UnityEngine.Windows.Speech;

public struct PhraseRecognizedEventArgs
{
	public readonly ConfidenceLevel confidence; //Field offset: 0x0
	public readonly SemanticMeaning[] semanticMeanings; //Field offset: 0x8
	public readonly string text; //Field offset: 0x10
	public readonly DateTime phraseStartTime; //Field offset: 0x18
	public readonly TimeSpan phraseDuration; //Field offset: 0x20

	internal PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }

}

