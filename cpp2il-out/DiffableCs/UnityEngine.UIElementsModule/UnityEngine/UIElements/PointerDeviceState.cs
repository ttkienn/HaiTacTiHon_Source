namespace UnityEngine.UIElements;

internal static class PointerDeviceState
{
	[Flags]
	public enum LocationFlag
	{
		None = 0,
		OutsidePanel = 1,
	}

	private struct PointerLocation
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private Vector2 <Position>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private IPanel <Panel>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private LocationFlag <Flags>k__BackingField; //Field offset: 0x10

		internal LocationFlag Flags
		{
			[CompilerGenerated]
			[IsReadOnly]
			internal get { } //Length: 191
			[CompilerGenerated]
			private set { } //Length: 4
		}

		internal IPanel Panel
		{
			[CompilerGenerated]
			[IsReadOnly]
			internal get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 13
		}

		internal Vector2 Position
		{
			[CompilerGenerated]
			[IsReadOnly]
			internal get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		[CompilerGenerated]
		[IsReadOnly]
		internal LocationFlag get_Flags() { }

		[CompilerGenerated]
		[IsReadOnly]
		internal IPanel get_Panel() { }

		[CompilerGenerated]
		[IsReadOnly]
		internal Vector2 get_Position() { }

		[CompilerGenerated]
		private void set_Flags(LocationFlag value) { }

		[CompilerGenerated]
		private void set_Panel(IPanel value) { }

		[CompilerGenerated]
		private void set_Position(Vector2 value) { }

		internal void SetLocation(Vector2 position, IPanel panel) { }

	}

	private static PointerLocation[] s_PlayerPointerLocations; //Field offset: 0x0
	private static Int32[] s_PressedButtons; //Field offset: 0x8
	private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture; //Field offset: 0x10

	private static PointerDeviceState() { }

	public static IPanel GetPanel(int pointerId, ContextType contextType) { }

	internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId) { }

	public static Vector2 GetPointerPosition(int pointerId, ContextType contextType) { }

	public static int GetPressedButtons(int pointerId) { }

	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag) { }

	public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag) { }

	public static void PressButton(int pointerId, int buttonId) { }

	public static void ReleaseAllButtons(int pointerId) { }

	public static void ReleaseButton(int pointerId, int buttonId) { }

	internal static void RemovePanelData(IPanel panel) { }

	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType) { }

	internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel) { }

}

