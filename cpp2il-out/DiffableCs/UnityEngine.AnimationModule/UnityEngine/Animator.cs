namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[UsedByNativeCode]
public class Animator : Behaviour
{

	public bool hasBoundPlayables
	{
		[NativeMethod("HasBoundPlayables")]
		 get { } //Length: 51
	}

	[NativeMethod("HasBoundPlayables")]
	public bool get_hasBoundPlayables() { }

	public void ResetTrigger(string name) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	private void ResetTriggerString(string name) { }

	public void SetTrigger(string name) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	private void SetTriggerString(string name) { }

}

