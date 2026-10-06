namespace UnityEngine.UIElements.UIR;

internal class VectorImageManager : IDisposable
{
	public static List<VectorImageManager> instances; //Field offset: 0x0
	private static ProfilerMarker s_MarkerRegister; //Field offset: 0x8
	private static ProfilerMarker s_MarkerUnregister; //Field offset: 0x10
	private readonly AtlasBase m_Atlas; //Field offset: 0x10
	private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered; //Field offset: 0x18
	private VectorImageRenderInfoPool m_RenderInfoPool; //Field offset: 0x20
	private GradientRemapPool m_GradientRemapPool; //Field offset: 0x28
	private GradientSettingsAtlas m_GradientSettingsAtlas; //Field offset: 0x30
	private bool m_LoggedExhaustedSettingsAtlas; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x39

	public Texture2D atlas
	{
		 get { } //Length: 32
	}

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static VectorImageManager() { }

	public VectorImageManager(AtlasBase atlas) { }

	public GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	public void Commit() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public Texture2D get_atlas() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

