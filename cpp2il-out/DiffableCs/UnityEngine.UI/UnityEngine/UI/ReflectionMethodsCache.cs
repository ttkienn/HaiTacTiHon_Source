namespace UnityEngine.UI;

internal class ReflectionMethodsCache
{
	internal sealed class GetRaycastNonAllocCallback : MulticastDelegate
	{

		public GetRaycastNonAllocCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	}

	internal sealed class GetRayIntersectionAllCallback : MulticastDelegate
	{

		public GetRayIntersectionAllCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

		public override RaycastHit2D[] EndInvoke(IAsyncResult result) { }

		public override RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	}

	internal sealed class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
	{

		public GetRayIntersectionAllNonAllocCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	}

	internal sealed class Raycast2DCallback : MulticastDelegate
	{

		public Raycast2DCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

		public override RaycastHit2D EndInvoke(IAsyncResult result) { }

		public override RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	}

	internal sealed class Raycast3DCallback : MulticastDelegate
	{

		public Raycast3DCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

		public override bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

		public override bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	}

	internal sealed class RaycastAllCallback : MulticastDelegate
	{

		public RaycastAllCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

		public override RaycastHit[] EndInvoke(IAsyncResult result) { }

		public override RaycastHit[] Invoke(Ray r, float f, int i) { }

	}

	private static ReflectionMethodsCache s_ReflectionMethodsCache; //Field offset: 0x0
	public Raycast3DCallback raycast3D; //Field offset: 0x10
	public RaycastAllCallback raycast3DAll; //Field offset: 0x18
	public GetRaycastNonAllocCallback getRaycastNonAlloc; //Field offset: 0x20
	public Raycast2DCallback raycast2D; //Field offset: 0x28
	public GetRayIntersectionAllCallback getRayIntersectionAll; //Field offset: 0x30
	public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; //Field offset: 0x38

	public static ReflectionMethodsCache Singleton
	{
		 get { } //Length: 141
	}

	public ReflectionMethodsCache() { }

	public static ReflectionMethodsCache get_Singleton() { }

}

