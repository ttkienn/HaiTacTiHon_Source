namespace UnityEngine.Playables;

public interface IPlayableBehaviour
{

	[RequiredByNativeCode]
	public void OnBehaviourPause(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	public void OnBehaviourPlay(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	public void OnGraphStart(Playable playable) { }

	[RequiredByNativeCode]
	public void OnGraphStop(Playable playable) { }

	[RequiredByNativeCode]
	public void OnPlayableCreate(Playable playable) { }

	[RequiredByNativeCode]
	public void OnPlayableDestroy(Playable playable) { }

	[RequiredByNativeCode]
	public void PrepareFrame(Playable playable, FrameData info) { }

	[RequiredByNativeCode]
	public void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

