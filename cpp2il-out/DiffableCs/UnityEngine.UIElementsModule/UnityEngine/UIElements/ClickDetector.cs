namespace UnityEngine.UIElements;

internal class ClickDetector
{
	private class ButtonClickStatus
	{
		public VisualElement m_Target; //Field offset: 0x10
		public Vector3 m_PointerDownPosition; //Field offset: 0x18
		public long m_LastPointerDownTime; //Field offset: 0x28
		public int m_ClickCount; //Field offset: 0x30

		public ButtonClickStatus() { }

		public void Reset() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static int <s_DoubleClickTime>k__BackingField; //Field offset: 0x0
	private List<ButtonClickStatus> m_ClickStatus; //Field offset: 0x10

	internal static int s_DoubleClickTime
	{
		[CompilerGenerated]
		internal get { } //Length: 77
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	private static ClickDetector() { }

	public ClickDetector() { }

	private void CancelClickTracking(EventBase evt) { }

	internal void Cleanup(List<VisualElement> elements) { }

	private static bool ContainsPointer(VisualElement element, Vector2 position) { }

	[CompilerGenerated]
	internal static int get_s_DoubleClickTime() { }

	public void ProcessEvent(EventBase evt) { }

	private void SendClickEvent(EventBase evt) { }

	[CompilerGenerated]
	internal static void set_s_DoubleClickTime(int value) { }

	private void StartClickTracking(EventBase evt) { }

}

