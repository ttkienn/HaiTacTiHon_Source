namespace UnityEngine;

[NativeClass("TextRendering::Font")]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[StaticAccessor("TextRenderingPrivate", StaticAccessorType::DoubleColon (2))]
public sealed class Font : object
{
	internal sealed class FontTextureRebuildCallback : MulticastDelegate
	{

		public FontTextureRebuildCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Font> textureRebuilt; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; //Field offset: 0x18

	public static event Action<Font> textureRebuilt
	{
		[CompilerGenerated]
		 add { } //Length: 219
		[CompilerGenerated]
		 remove { } //Length: 219
	}

	public bool dynamic
	{
		 get { } //Length: 51
	}

	public int fontSize
	{
		 get { } //Length: 51
	}

	public Material material
	{
		 get { } //Length: 51
	}

	public Font() { }

	[CompilerGenerated]
	public static void add_textureRebuilt(Action<Font> value) { }

	public bool get_dynamic() { }

	public int get_fontSize() { }

	public Material get_material() { }

	public bool HasCharacter(char c) { }

	private bool HasCharacter(int c) { }

	private static void Internal_CreateFont(Font self, string name) { }

	[RequiredByNativeCode]
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	[CompilerGenerated]
	public static void remove_textureRebuilt(Action<Font> value) { }

}

