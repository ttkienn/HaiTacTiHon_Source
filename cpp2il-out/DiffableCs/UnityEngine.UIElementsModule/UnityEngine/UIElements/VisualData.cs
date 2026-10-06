namespace UnityEngine.UIElements;

internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData>
{
	public Color backgroundColor; //Field offset: 0x0
	public Background backgroundImage; //Field offset: 0x10
	public BackgroundPosition backgroundPositionX; //Field offset: 0x30
	public BackgroundPosition backgroundPositionY; //Field offset: 0x3C
	public BackgroundRepeat backgroundRepeat; //Field offset: 0x48
	public BackgroundSize backgroundSize; //Field offset: 0x50
	public Color borderBottomColor; //Field offset: 0x64
	public Length borderBottomLeftRadius; //Field offset: 0x74
	public Length borderBottomRightRadius; //Field offset: 0x7C
	public Color borderLeftColor; //Field offset: 0x84
	public Color borderRightColor; //Field offset: 0x94
	public Color borderTopColor; //Field offset: 0xA4
	public Length borderTopLeftRadius; //Field offset: 0xB4
	public Length borderTopRightRadius; //Field offset: 0xBC
	public float opacity; //Field offset: 0xC4
	public OverflowInternal overflow; //Field offset: 0xC8

	public override VisualData Copy() { }

	public override void CopyFrom(ref VisualData other) { }

	public override bool Equals(VisualData other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(VisualData lhs, VisualData rhs) { }

}

