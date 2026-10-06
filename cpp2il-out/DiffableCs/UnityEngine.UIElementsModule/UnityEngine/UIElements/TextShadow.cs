namespace UnityEngine.UIElements;

public struct TextShadow : IEquatable<TextShadow>
{
	public Vector2 offset; //Field offset: 0x0
	public float blurRadius; //Field offset: 0x8
	public Color color; //Field offset: 0xC

	public virtual bool Equals(object obj) { }

	public override bool Equals(TextShadow other) { }

	public virtual int GetHashCode() { }

	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) { }

	public static bool op_Equality(TextShadow style1, TextShadow style2) { }

	public static bool op_Inequality(TextShadow style1, TextShadow style2) { }

	public virtual string ToString() { }

}

