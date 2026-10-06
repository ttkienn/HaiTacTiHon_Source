namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
internal class CameraRaycastHelper
{

	[FreeFunction("CameraScripting::RaycastTry")]
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	[FreeFunction("CameraScripting::RaycastTry2D")]
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

}

