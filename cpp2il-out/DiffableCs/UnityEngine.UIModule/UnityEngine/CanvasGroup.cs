namespace UnityEngine;

[NativeClass("UI::CanvasGroup")]
[NativeHeader("Modules/UI/CanvasGroup.h")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{

	[NativeProperty("Alpha", False, TargetType::Function (0))]
	public float alpha
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty("BlocksRaycasts", False, TargetType::Function (0))]
	public bool blocksRaycasts
	{
		 get { } //Length: 51
	}

	[NativeProperty("IgnoreParentGroups", False, TargetType::Function (0))]
	public bool ignoreParentGroups
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("Interactable", False, TargetType::Function (0))]
	public bool interactable
	{
		 get { } //Length: 51
	}

	public CanvasGroup() { }

	public float get_alpha() { }

	public bool get_blocksRaycasts() { }

	public bool get_ignoreParentGroups() { }

	public bool get_interactable() { }

	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	public void set_alpha(float value) { }

	public void set_ignoreParentGroups(bool value) { }

}

