namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct Playable : IEquatable<Playable>
{
	private static readonly Playable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	public static Playable Null
	{
		 get { } //Length: 96
	}

	private static Playable() { }

	[VisibleToOtherModules]
	internal Playable(PlayableHandle handle) { }

	public override bool Equals(Playable other) { }

	public static Playable get_Null() { }

	public override PlayableHandle GetHandle() { }

}

