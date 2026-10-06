namespace UnityEngine.UIElements;

public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal NavigationMoveEvent <.cctor>b__0_0() { }

	}

	internal enum Direction
	{
		None = 0,
		Left = 1,
		Up = 2,
		Right = 3,
		Down = 4,
		Next = 5,
		Previous = 6,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Direction <direction>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <move>k__BackingField; //Field offset: 0x94

	public private Direction direction
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private Vector2 move
	{
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static NavigationMoveEvent() { }

	public NavigationMoveEvent() { }

	internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6) { }

	[CompilerGenerated]
	public Direction get_direction() { }

	public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers = 0) { }

	internal static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	public static NavigationMoveEvent GetPooled(Direction direction, EventModifiers modifiers = 0) { }

	internal static NavigationMoveEvent GetPooled(Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_direction(Direction value) { }

	[CompilerGenerated]
	private void set_move(Vector2 value) { }

}

