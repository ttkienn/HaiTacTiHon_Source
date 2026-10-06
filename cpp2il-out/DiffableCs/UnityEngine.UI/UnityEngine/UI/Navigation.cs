namespace UnityEngine.UI;

public struct Navigation : IEquatable<Navigation>
{
	[Flags]
	internal enum Mode
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Automatic = 3,
		Explicit = 4,
	}

	[SerializeField]
	private Mode m_Mode; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	private bool m_WrapAround; //Field offset: 0x4
	[SerializeField]
	private Selectable m_SelectOnUp; //Field offset: 0x8
	[SerializeField]
	private Selectable m_SelectOnDown; //Field offset: 0x10
	[SerializeField]
	private Selectable m_SelectOnLeft; //Field offset: 0x18
	[SerializeField]
	private Selectable m_SelectOnRight; //Field offset: 0x20

	public static Navigation defaultNavigation
	{
		 get { } //Length: 26
	}

	public Mode mode
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	public Selectable selectOnDown
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Selectable selectOnLeft
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Selectable selectOnRight
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public Selectable selectOnUp
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public bool wrapAround
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public override bool Equals(Navigation other) { }

	public static Navigation get_defaultNavigation() { }

	public Mode get_mode() { }

	public Selectable get_selectOnDown() { }

	public Selectable get_selectOnLeft() { }

	public Selectable get_selectOnRight() { }

	public Selectable get_selectOnUp() { }

	public bool get_wrapAround() { }

	public void set_mode(Mode value) { }

	public void set_selectOnDown(Selectable value) { }

	public void set_selectOnLeft(Selectable value) { }

	public void set_selectOnRight(Selectable value) { }

	public void set_selectOnUp(Selectable value) { }

	public void set_wrapAround(bool value) { }

}

