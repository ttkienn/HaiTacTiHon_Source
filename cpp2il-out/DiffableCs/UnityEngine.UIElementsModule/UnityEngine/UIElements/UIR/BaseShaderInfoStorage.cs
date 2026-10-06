namespace UnityEngine.UIElements.UIR;

internal abstract class BaseShaderInfoStorage : IDisposable
{
	protected static int s_TextureCounter; //Field offset: 0x0
	internal static ProfilerMarker s_MarkerCopyTexture; //Field offset: 0x8
	internal static ProfilerMarker s_MarkerGetTextureData; //Field offset: 0x10
	internal static ProfilerMarker s_MarkerUpdateTexture; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x10

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public abstract Texture2D texture
	{
		 get { } //Length: 0
	}

	private static BaseShaderInfoStorage() { }

	protected BaseShaderInfoStorage() { }

	public abstract bool AllocateRect(int width, int height, out RectInt uvs) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	public abstract Texture2D get_texture() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	public abstract void SetTexel(int x, int y, Color color) { }

	public abstract void UpdateTexture() { }

}

