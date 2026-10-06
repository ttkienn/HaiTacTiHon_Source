namespace UnityEngine.UIElements;

public struct BackgroundRepeat : IEquatable<BackgroundRepeat>
{
	public Repeat x; //Field offset: 0x0
	public Repeat y; //Field offset: 0x4

	public BackgroundRepeat(Repeat repeatX, Repeat repeatY) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(BackgroundRepeat other) { }

	public virtual int GetHashCode() { }

	internal static BackgroundRepeat Initial() { }

	public static bool op_Equality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	public static bool op_Inequality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	public virtual string ToString() { }

}

