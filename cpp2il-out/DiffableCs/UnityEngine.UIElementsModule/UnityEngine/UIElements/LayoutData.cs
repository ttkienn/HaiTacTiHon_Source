namespace UnityEngine.UIElements;

internal struct LayoutData : IStyleDataGroup<LayoutData>, IEquatable<LayoutData>
{
	public Align alignContent; //Field offset: 0x0
	public Align alignItems; //Field offset: 0x4
	public Align alignSelf; //Field offset: 0x8
	public float borderBottomWidth; //Field offset: 0xC
	public float borderLeftWidth; //Field offset: 0x10
	public float borderRightWidth; //Field offset: 0x14
	public float borderTopWidth; //Field offset: 0x18
	public Length bottom; //Field offset: 0x1C
	public DisplayStyle display; //Field offset: 0x24
	public Length flexBasis; //Field offset: 0x28
	public FlexDirection flexDirection; //Field offset: 0x30
	public float flexGrow; //Field offset: 0x34
	public float flexShrink; //Field offset: 0x38
	public Wrap flexWrap; //Field offset: 0x3C
	public Length height; //Field offset: 0x40
	public Justify justifyContent; //Field offset: 0x48
	public Length left; //Field offset: 0x4C
	public Length marginBottom; //Field offset: 0x54
	public Length marginLeft; //Field offset: 0x5C
	public Length marginRight; //Field offset: 0x64
	public Length marginTop; //Field offset: 0x6C
	public Length maxHeight; //Field offset: 0x74
	public Length maxWidth; //Field offset: 0x7C
	public Length minHeight; //Field offset: 0x84
	public Length minWidth; //Field offset: 0x8C
	public Length paddingBottom; //Field offset: 0x94
	public Length paddingLeft; //Field offset: 0x9C
	public Length paddingRight; //Field offset: 0xA4
	public Length paddingTop; //Field offset: 0xAC
	public Position position; //Field offset: 0xB4
	public Length right; //Field offset: 0xB8
	public Length top; //Field offset: 0xC0
	public Length width; //Field offset: 0xC8

	public override LayoutData Copy() { }

	public override void CopyFrom(ref LayoutData other) { }

	public override bool Equals(LayoutData other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(LayoutData lhs, LayoutData rhs) { }

}

