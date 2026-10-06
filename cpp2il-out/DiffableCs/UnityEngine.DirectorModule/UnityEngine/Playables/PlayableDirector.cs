namespace UnityEngine.Playables;

[NativeHeader("Modules/Director/PlayableDirector.h")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class PlayableDirector : Behaviour
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<PlayableDirector> played; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<PlayableDirector> paused; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<PlayableDirector> stopped; //Field offset: 0x28

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCode]
	private void SendOnPlayableDirectorStop() { }

}

