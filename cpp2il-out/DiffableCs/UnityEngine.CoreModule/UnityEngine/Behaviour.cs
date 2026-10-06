namespace UnityEngine;

[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[UsedByNativeCode]
public class Behaviour : Component
{

	[NativeProperty]
	[RequiredByNativeCode]
	public bool enabled
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool isActiveAndEnabled
	{
		[NativeMethod("IsAddedToManager")]
		 get { } //Length: 51
	}

	public Behaviour() { }

	public bool get_enabled() { }

	[NativeMethod("IsAddedToManager")]
	public bool get_isActiveAndEnabled() { }

	public void set_enabled(bool value) { }

}

