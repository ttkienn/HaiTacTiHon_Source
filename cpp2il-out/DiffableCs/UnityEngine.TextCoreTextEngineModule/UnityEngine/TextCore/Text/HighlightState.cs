namespace UnityEngine.TextCore.Text;

internal struct HighlightState
{
	public Color32 color; //Field offset: 0x0
	public Offset padding; //Field offset: 0x4

	public HighlightState(Color32 color, Offset padding) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

}

