namespace UnityEngine.Playables;

public struct PlayableBinding
{
	[VisibleToOtherModules]
	public sealed class CreateOutputMethod : MulticastDelegate
	{

		public CreateOutputMethod(object object, IntPtr method) { }

		public override PlayableOutput Invoke(PlayableGraph graph, string name) { }

	}

	public static readonly PlayableBinding[] None; //Field offset: 0x0
	public static readonly double DefaultDuration; //Field offset: 0x8
	private string m_StreamName; //Field offset: 0x0
	private object m_SourceObject; //Field offset: 0x8
	private Type m_SourceBindingType; //Field offset: 0x10
	private CreateOutputMethod m_CreateOutputMethod; //Field offset: 0x18

	private static PlayableBinding() { }

}

