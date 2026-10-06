namespace UnityEngine.UIElements.UIR;

internal class UIRenderDevice : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MeshHandle> <>9__50_0; //Field offset: 0x8
		public static Action<MeshHandle> <>9__50_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal MeshHandle <.ctor>b__50_0() { }

		internal void <.ctor>b__50_1(MeshHandle mh) { }

	}

	private struct AllocToFree
	{
		public Alloc alloc; //Field offset: 0x0
		public Page page; //Field offset: 0x18
		public bool vertices; //Field offset: 0x20

	}

	public struct AllocToUpdate
	{
		public uint id; //Field offset: 0x0
		public uint allocTime; //Field offset: 0x4
		public MeshHandle meshHandle; //Field offset: 0x8
		public Alloc permAllocVerts; //Field offset: 0x10
		public Alloc permAllocIndices; //Field offset: 0x28
		public Page permPage; //Field offset: 0x40
		public bool copyBackIndices; //Field offset: 0x48

	}

	private struct DeviceToFree
	{
		public uint handle; //Field offset: 0x0
		public Page page; //Field offset: 0x8

		public void Dispose() { }

	}

	public struct DrawStatistics
	{
		public int currentFrameIndex; //Field offset: 0x0
		public uint totalIndices; //Field offset: 0x4
		public uint commandCount; //Field offset: 0x8
		public uint drawCommandCount; //Field offset: 0xC
		public uint materialSetCount; //Field offset: 0x10
		public uint drawRangeCount; //Field offset: 0x14
		public uint drawRangeCallCount; //Field offset: 0x18
		public uint immediateDraws; //Field offset: 0x1C
		public uint stencilRefChanges; //Field offset: 0x20

	}

	private struct EvaluationState
	{
		public MaterialPropertyBlock stateMatProps; //Field offset: 0x0
		public Material defaultMat; //Field offset: 0x8
		public State curState; //Field offset: 0x10
		public Page curPage; //Field offset: 0x28
		public bool mustApplyMaterial; //Field offset: 0x30
		public bool mustApplyCommonBlock; //Field offset: 0x31
		public bool mustApplyStateBlock; //Field offset: 0x32
		public bool mustApplyStencil; //Field offset: 0x33

	}

	private static LinkedList<DeviceToFree> m_DeviceFreeQueue; //Field offset: 0x0
	private static int m_ActiveDeviceCount; //Field offset: 0x8
	private static bool m_SubscribedToNotifications; //Field offset: 0xC
	private static bool m_SynchronousFree; //Field offset: 0xD
	private static readonly int s_GradientSettingsTexID; //Field offset: 0x10
	private static readonly int s_ShaderInfoTexID; //Field offset: 0x14
	private static readonly int s_TransformsPropID; //Field offset: 0x18
	private static readonly int s_ClipRectsPropID; //Field offset: 0x1C
	private static ProfilerMarker s_MarkerAllocate; //Field offset: 0x20
	private static ProfilerMarker s_MarkerFree; //Field offset: 0x28
	private static ProfilerMarker s_MarkerAdvanceFrame; //Field offset: 0x30
	private static ProfilerMarker s_MarkerFence; //Field offset: 0x38
	private static ProfilerMarker s_MarkerBeforeDraw; //Field offset: 0x40
	private static Nullable<Boolean> s_VertexTexturingIsAvailable; //Field offset: 0x48
	private static Nullable<Boolean> s_ShaderModelIs35; //Field offset: 0x4A
	private static Texture2D s_DefaultShaderInfoTexFloat; //Field offset: 0x50
	private static Texture2D s_DefaultShaderInfoTexARGB8; //Field offset: 0x58
	private readonly bool m_MockDevice; //Field offset: 0x10
	private IntPtr m_DefaultStencilState; //Field offset: 0x18
	private IntPtr m_VertexDecl; //Field offset: 0x20
	private Page m_FirstPage; //Field offset: 0x28
	private uint m_NextPageVertexCount; //Field offset: 0x30
	private uint m_LargeMeshVertexCount; //Field offset: 0x34
	private float m_IndexToVertexCountRatio; //Field offset: 0x38
	private List<List`1<AllocToFree>> m_DeferredFrees; //Field offset: 0x40
	private List<List`1<AllocToUpdate>> m_Updates; //Field offset: 0x48
	private UInt32[] m_Fences; //Field offset: 0x50
	private MaterialPropertyBlock m_StandardMatProps; //Field offset: 0x58
	private uint m_FrameIndex; //Field offset: 0x60
	private uint m_NextUpdateID; //Field offset: 0x64
	private DrawStatistics m_DrawStats; //Field offset: 0x68
	private readonly LinkedPool<MeshHandle> m_MeshHandles; //Field offset: 0x90
	private readonly DrawParams m_DrawParams; //Field offset: 0x98
	private readonly TextureSlotManager m_TextureSlotManager; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly uint <maxVerticesPerPage>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <breakBatches>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0xAD

	internal bool breakBatches
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal static Texture2D defaultShaderInfoTexARGB8
	{
		internal get { } //Length: 973
	}

	internal static Texture2D defaultShaderInfoTexFloat
	{
		internal get { } //Length: 1476
	}

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool fullyCreated
	{
		private get { } //Length: 11
	}

	internal uint maxVerticesPerPage
	{
		[CompilerGenerated]
		internal get { } //Length: 7
	}

	internal static bool shaderModelIs35
	{
		internal get { } //Length: 479
	}

	internal static bool vertexTexturingIsAvailable
	{
		internal get { } //Length: 479
	}

	private static UIRenderDevice() { }

	public UIRenderDevice(uint initialVertexCapacity = 0, uint initialIndexCapacity = 0) { }

	protected UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice) { }

	internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	public void AdvanceFrame() { }

	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset) { }

	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, bool shortLived) { }

	private void ApplyBatchState(ref EvaluationState st, bool allowMaterialChange) { }

	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref EvaluationState st) { }

	private void CompleteCreation() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	private void DrawRanges(GPUBuffer<I> ib, GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges) { }

	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException) { }

	internal static void FlushAllPendingDeviceDisposes() { }

	public void Free(MeshHandle mesh) { }

	internal DrawStatistics GatherDrawStatistics() { }

	[CompilerGenerated]
	internal bool get_breakBatches() { }

	internal static Texture2D get_defaultShaderInfoTexARGB8() { }

	internal static Texture2D get_defaultShaderInfoTexFloat() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	private bool get_fullyCreated() { }

	[CompilerGenerated]
	internal uint get_maxVerticesPerPage() { }

	internal static bool get_shaderModelIs35() { }

	internal static bool get_vertexTexturingIsAvailable() { }

	private void InitVertexDeclaration() { }

	private void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage) { }

	private static void OnEngineUpdateGlobal() { }

	private static void OnFlushPendingResources() { }

	public void OnFrameRenderingBegin() { }

	internal static void PrepareForGfxDeviceRecreate() { }

	public static void ProcessDeviceFreeQueue() { }

	private void PruneUnusedPages() { }

	internal static NativeSlice<T> PtrToSlice(Void* p, int count) { }

	[CompilerGenerated]
	internal void set_breakBatches(bool value) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) { }

	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset) { }

	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex>& vertexData) { }

	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex>& vertexData, out NativeSlice<UInt16>& indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	private void UpdateFenceValue() { }

	private void WaitOnCpuFence(uint fence) { }

	internal static void WrapUpGfxDeviceRecreate() { }

}

