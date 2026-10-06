namespace UnityEngine.UIElements;

public struct BackgroundPosition : IEquatable<BackgroundPosition>
{
	public BackgroundPositionKeyword keyword; //Field offset: 0x0
	public Length offset; //Field offset: 0x4

	public BackgroundPosition(BackgroundPositionKeyword keyword) { }

	public BackgroundPosition(BackgroundPositionKeyword keyword, Length offset) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(BackgroundPosition other) { }

	public virtual int GetHashCode() { }

	internal static BackgroundPosition Initial() { }

	public static bool op_Equality(BackgroundPosition style1, BackgroundPosition style2) { }

	public static bool op_Inequality(BackgroundPosition style1, BackgroundPosition style2) { }

	public virtual string ToString() { }

}

