namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
public class AnimatorOverrideController : RuntimeAnimatorController
{
	public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
	{

		public OnOverrideControllerDirtyCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; //Field offset: 0x18

	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

