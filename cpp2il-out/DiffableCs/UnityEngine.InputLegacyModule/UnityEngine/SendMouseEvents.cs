namespace UnityEngine;

internal class SendMouseEvents
{
	private struct HitInfo
	{
		public GameObject target; //Field offset: 0x0
		public Camera camera; //Field offset: 0x8

		public static bool Compare(HitInfo lhs, HitInfo rhs) { }

		public static bool op_Implicit(HitInfo exists) { }

		public void SendMessage(string name) { }

	}

	private static bool s_MouseUsed; //Field offset: 0x0
	private static readonly HitInfo[] m_LastHit; //Field offset: 0x8
	private static readonly HitInfo[] m_MouseDownHit; //Field offset: 0x10
	private static readonly HitInfo[] m_CurrentHit; //Field offset: 0x18
	private static Camera[] m_Cameras; //Field offset: 0x20
	public static Func<KeyValuePair`2<Int32, Vector2>> s_GetMouseState; //Field offset: 0x28
	private static Vector2 s_MousePosition; //Field offset: 0x30
	private static bool s_MouseButtonPressedThisFrame; //Field offset: 0x38
	private static bool s_MouseButtonIsPressed; //Field offset: 0x39

	private static SendMouseEvents() { }

	[RequiredByNativeCode]
	private static void DoSendMouseEvents(int skipRTCameras) { }

	private static void SendEvents(int i, HitInfo hit) { }

	[RequiredByNativeCode]
	private static void SetMouseMoved() { }

	private static void UpdateMouse() { }

}

