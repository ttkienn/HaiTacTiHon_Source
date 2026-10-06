namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct PlayableOutput : IEquatable<PlayableOutput>
{
	private static readonly PlayableOutput m_NullPlayableOutput; //Field offset: 0x0
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	private static PlayableOutput() { }

	[VisibleToOtherModules]
	internal PlayableOutput(PlayableOutputHandle handle) { }

	public override bool Equals(PlayableOutput other) { }

	public override PlayableOutputHandle GetHandle() { }

}

