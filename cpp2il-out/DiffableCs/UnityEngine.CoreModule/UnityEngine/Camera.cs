namespace UnityEngine;

[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	internal sealed class CameraCallback : MulticastDelegate
	{

		public CameraCallback(object object, IntPtr method) { }

		public override void Invoke(Camera cam) { }

	}

	internal enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	public const float kMinAperture = 0.7; //Field offset: 0x0
	public const float kMaxAperture = 32; //Field offset: 0x0
	public const int kMinBladeCount = 3; //Field offset: 0x0
	public const int kMaxBladeCount = 11; //Field offset: 0x0
	public static CameraCallback onPreCull; //Field offset: 0x0
	public static CameraCallback onPreRender; //Field offset: 0x8
	public static CameraCallback onPostRender; //Field offset: 0x10

	public static int allCamerasCount
	{
		 get { } //Length: 42
	}

	public Color backgroundColor
	{
		 set { } //Length: 66
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 51
	}

	public int cullingMask
	{
		 get { } //Length: 51
	}

	public static Camera current
	{
		[FreeFunction("GetCurrentCameraPPtr")]
		 get { } //Length: 42
	}

	public float depth
	{
		 get { } //Length: 51
	}

	public int eventMask
	{
		 get { } //Length: 51
	}

	[NativeProperty("Far")]
	public float farClipPlane
	{
		 get { } //Length: 51
	}

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		 get { } //Length: 42
	}

	[NativeProperty("Near")]
	public float nearClipPlane
	{
		 get { } //Length: 51
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect
	{
		 get { } //Length: 75
	}

	public int targetDisplay
	{
		 get { } //Length: 51
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 51
	}

	public Camera() { }

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam) { }

	public static int get_allCamerasCount() { }

	public CameraClearFlags get_clearFlags() { }

	public int get_cullingMask() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	public static Camera get_current() { }

	public float get_depth() { }

	public int get_eventMask() { }

	public float get_farClipPlane() { }

	[FreeFunction("FindMainCamera")]
	public static Camera get_main() { }

	public float get_nearClipPlane() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	public int get_targetDisplay() { }

	public RenderTexture get_targetTexture() { }

	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public void set_backgroundColor(Color value) { }

	private void set_backgroundColor_Injected(ref Color value) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

