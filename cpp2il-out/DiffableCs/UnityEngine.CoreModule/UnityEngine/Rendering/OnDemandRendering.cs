namespace UnityEngine.Rendering;

[RequiredByNativeCode]
public class OnDemandRendering
{
	private static int m_RenderFrameInterval; //Field offset: 0x0

	public static int renderFrameInterval
	{
		 get { } //Length: 77
	}

	private static OnDemandRendering() { }

	public static int get_renderFrameInterval() { }

	[RequiredByNativeCode]
	internal static void GetRenderFrameInterval(out int frameInterval) { }

}

