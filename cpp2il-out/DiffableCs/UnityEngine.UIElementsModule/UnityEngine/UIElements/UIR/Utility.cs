namespace UnityEngine.UIElements.UIR;

[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/Renderer/UIRendererUtility.h")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Unity.UIElements"}])]
internal class Utility
{
	internal class GPUBuffer : IDisposable
	{
		private IntPtr buffer; //Field offset: 0x0
		private int elemCount; //Field offset: 0x0
		private int elemStride; //Field offset: 0x0

		internal IntPtr BufferPointer
		{
			internal get { } //Length: 7
		}

		public int ElementStride
		{
			 get { } //Length: 6
		}

		public GPUBuffer`1(int elementCount, GPUBufferType type) { }

		public override void Dispose() { }

		internal IntPtr get_BufferPointer() { }

		public int get_ElementStride() { }

		public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) { }

	}

	public enum GPUBufferType
	{
		Vertex = 0,
		Index = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Boolean> GraphicsResourcesRecreate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action EngineUpdate; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action FlushPendingResources; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Camera> RegisterIntermediateRenderers; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<IntPtr> RenderNodeAdd; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<IntPtr> RenderNodeExecute; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<IntPtr> RenderNodeCleanup; //Field offset: 0x30
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; //Field offset: 0x38

	public static event Action EngineUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 242
		[CompilerGenerated]
		 remove { } //Length: 242
	}

	public static event Action FlushPendingResources
	{
		[CompilerGenerated]
		 add { } //Length: 242
		[CompilerGenerated]
		 remove { } //Length: 242
	}

	public static event Action<Boolean> GraphicsResourcesRecreate
	{
		[CompilerGenerated]
		 add { } //Length: 257
		[CompilerGenerated]
		 remove { } //Length: 257
	}

	public static event Action<Camera> RegisterIntermediateRenderers
	{
		[CompilerGenerated]
		 add { } //Length: 261
		[CompilerGenerated]
		 remove { } //Length: 261
	}

	public static event Action<IntPtr> RenderNodeExecute
	{
		[CompilerGenerated]
		 add { } //Length: 261
		[CompilerGenerated]
		 remove { } //Length: 261
	}

	private static Utility() { }

	[CompilerGenerated]
	public static void add_EngineUpdate(Action value) { }

	[CompilerGenerated]
	public static void add_FlushPendingResources(Action value) { }

	[CompilerGenerated]
	public static void add_GraphicsResourcesRecreate(Action<Boolean> value) { }

	[CompilerGenerated]
	public static void add_RegisterIntermediateRenderers(Action<Camera> value) { }

	[CompilerGenerated]
	public static void add_RenderNodeExecute(Action<IntPtr> value) { }

	[ThreadSafe]
	private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	[ThreadSafe]
	public static bool CPUFencePassed(uint fence) { }

	[ThreadSafe]
	public static IntPtr CreateStencilState(StencilState stencilState) { }

	private static IntPtr CreateStencilState_Injected(ref StencilState stencilState) { }

	[ThreadSafe]
	public static void DisableScissor() { }

	[ThreadSafe]
	public static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	[ThreadSafe]
	private static void FreeBuffer(IntPtr buffer) { }

	[ThreadSafe]
	public static RectInt GetActiveViewport() { }

	private static void GetActiveViewport_Injected(out RectInt ret) { }

	[ThreadSafe]
	public static Matrix4x4 GetUnityProjectionMatrix() { }

	private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret) { }

	[ThreadSafe]
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	[ThreadSafe]
	public static bool HasMappedBufferRange() { }

	[ThreadSafe]
	public static uint InsertCPUFence() { }

	public static void NotifyOfUIREvents(bool subscribe) { }

	[ThreadSafe]
	public static void ProfileDrawChainBegin() { }

	[ThreadSafe]
	public static void ProfileDrawChainEnd() { }

	[RequiredByNativeCode]
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCode]
	internal static void RaiseFlushPendingResources() { }

	[RequiredByNativeCode]
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCode]
	internal static void RaiseRegisterIntermediateRenderers(Camera camera) { }

	[RequiredByNativeCode]
	internal static void RaiseRenderNodeAdd(IntPtr userData) { }

	[RequiredByNativeCode]
	internal static void RaiseRenderNodeCleanup(IntPtr userData) { }

	[RequiredByNativeCode]
	internal static void RaiseRenderNodeExecute(IntPtr userData) { }

	public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	private static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	[CompilerGenerated]
	public static void remove_EngineUpdate(Action value) { }

	[CompilerGenerated]
	public static void remove_FlushPendingResources(Action value) { }

	[CompilerGenerated]
	public static void remove_GraphicsResourcesRecreate(Action<Boolean> value) { }

	[CompilerGenerated]
	public static void remove_RegisterIntermediateRenderers(Action<Camera> value) { }

	[CompilerGenerated]
	public static void remove_RenderNodeExecute(Action<IntPtr> value) { }

	[ThreadSafe]
	public static void SetPropertyBlock(MaterialPropertyBlock props) { }

	[ThreadSafe]
	public static void SetScissorRect(RectInt scissorRect) { }

	private static void SetScissorRect_Injected(ref RectInt scissorRect) { }

	[ThreadSafe]
	public static void SetStencilState(IntPtr stencilState, int stencilRef) { }

	[ThreadSafe]
	private static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count) { }

	public static void SetVectorArray(MaterialPropertyBlock props, int name, NativeSlice<T> vector4s) { }

	[ThreadSafe]
	public static void SyncRenderThread() { }

	[ThreadSafe]
	private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	[ThreadSafe]
	public static void WaitForCPUFencePassed(uint fence) { }

}

