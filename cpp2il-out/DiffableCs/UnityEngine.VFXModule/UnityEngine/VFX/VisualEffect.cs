namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[RequireComponent(typeof(Transform))]
public class VisualEffect : Behaviour
{
	private VFXEventAttribute m_cachedEventAttribute; //Field offset: 0x18
	public Action<VFXOutputEventArgs> outputEventReceived; //Field offset: 0x20

	public VisualEffectAsset visualEffectAsset
	{
		 get { } //Length: 51
	}

	public VFXEventAttribute CreateVFXEventAttribute() { }

	public VisualEffectAsset get_visualEffectAsset() { }

	[RequiredByNativeCode]
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[RequiredByNativeCode]
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }

}

