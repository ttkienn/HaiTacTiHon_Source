namespace UnityEngine.Playables;

[RequiredByNativeCode]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable
{

	public PlayableBehaviour() { }

	public override object Clone() { }

	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	public override void OnGraphStart(Playable playable) { }

	public override void OnGraphStop(Playable playable) { }

	public override void OnPlayableCreate(Playable playable) { }

	public override void OnPlayableDestroy(Playable playable) { }

	public override void PrepareFrame(Playable playable, FrameData info) { }

	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

