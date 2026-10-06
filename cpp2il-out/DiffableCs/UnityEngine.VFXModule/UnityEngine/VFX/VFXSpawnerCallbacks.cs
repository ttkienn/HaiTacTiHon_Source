namespace UnityEngine.VFX;

[RequiredByNativeCode]
public abstract class VFXSpawnerCallbacks : ScriptableObject
{

	protected VFXSpawnerCallbacks() { }

	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

}

