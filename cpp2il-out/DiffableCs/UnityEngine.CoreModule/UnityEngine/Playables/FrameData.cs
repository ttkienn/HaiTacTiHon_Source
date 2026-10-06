namespace UnityEngine.Playables;

public struct FrameData
{
	[Flags]
	public enum Flags
	{
		Evaluate = 1,
		SeekOccured = 2,
		Loop = 4,
		Hold = 8,
		EffectivePlayStateDelayed = 16,
		EffectivePlayStatePlaying = 32,
	}

	internal ulong m_FrameID; //Field offset: 0x0
	internal double m_DeltaTime; //Field offset: 0x8
	internal float m_Weight; //Field offset: 0x10
	internal float m_EffectiveWeight; //Field offset: 0x14
	internal double m_EffectiveParentDelay; //Field offset: 0x18
	internal float m_EffectiveParentSpeed; //Field offset: 0x20
	internal float m_EffectiveSpeed; //Field offset: 0x24
	internal Flags m_Flags; //Field offset: 0x28
	internal PlayableOutput m_Output; //Field offset: 0x30

}

