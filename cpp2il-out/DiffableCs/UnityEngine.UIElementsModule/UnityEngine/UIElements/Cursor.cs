namespace UnityEngine.UIElements;

public struct Cursor : IEquatable<Cursor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Texture2D <texture>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <hotspot>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <defaultCursorId>k__BackingField; //Field offset: 0x10

	internal int defaultCursorId
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 191
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public Vector2 hotspot
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Texture2D texture
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Cursor other) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal int get_defaultCursorId() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector2 get_hotspot() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Texture2D get_texture() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Cursor style1, Cursor style2) { }

	[CompilerGenerated]
	internal void set_defaultCursorId(int value) { }

	[CompilerGenerated]
	public void set_hotspot(Vector2 value) { }

	[CompilerGenerated]
	public void set_texture(Texture2D value) { }

	public virtual string ToString() { }

}

