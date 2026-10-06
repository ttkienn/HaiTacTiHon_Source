namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIState.h")]
[NativeHeader("Modules/IMGUI/GUIClip.h")]
internal sealed class GUIClip
{
	public struct ParentClipScope : IDisposable
	{
		private bool m_Disposed; //Field offset: 0x0

		public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect) { }

		public override void Dispose() { }

	}


	internal static Rect visibleRect
	{
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
		internal get { } //Length: 60
	}

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
	internal static Rect get_visibleRect() { }

	private static void get_visibleRect_Injected(out Rect ret) { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	internal static Matrix4x4 GetMatrix() { }

	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	internal static int Internal_GetCount() { }

	internal static void Internal_Pop() { }

	internal static void Internal_PopParentClip() { }

	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect) { }

	private static void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect) { }

	internal static void Pop() { }

	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	internal static void SetMatrix(Matrix4x4 m) { }

	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	public static Vector2 Unclip(Vector2 pos) { }

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.Unclip")]
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

}

