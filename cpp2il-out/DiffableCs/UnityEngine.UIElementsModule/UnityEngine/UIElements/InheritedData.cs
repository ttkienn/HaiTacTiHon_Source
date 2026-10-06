namespace UnityEngine.UIElements;

internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData>
{
	public Color color; //Field offset: 0x0
	public Length fontSize; //Field offset: 0x10
	public Length letterSpacing; //Field offset: 0x18
	public TextShadow textShadow; //Field offset: 0x20
	public Font unityFont; //Field offset: 0x40
	public FontDefinition unityFontDefinition; //Field offset: 0x48
	public FontStyle unityFontStyleAndWeight; //Field offset: 0x58
	public Length unityParagraphSpacing; //Field offset: 0x5C
	public TextAnchor unityTextAlign; //Field offset: 0x64
	public Color unityTextOutlineColor; //Field offset: 0x68
	public float unityTextOutlineWidth; //Field offset: 0x78
	public Visibility visibility; //Field offset: 0x7C
	public WhiteSpace whiteSpace; //Field offset: 0x80
	public Length wordSpacing; //Field offset: 0x84

	public override InheritedData Copy() { }

	public override void CopyFrom(ref InheritedData other) { }

	public override bool Equals(InheritedData other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(InheritedData lhs, InheritedData rhs) { }

}

