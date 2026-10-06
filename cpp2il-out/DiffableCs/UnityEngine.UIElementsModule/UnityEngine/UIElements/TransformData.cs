namespace UnityEngine.UIElements;

internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData>
{
	public Rotate rotate; //Field offset: 0x0
	public Scale scale; //Field offset: 0x18
	public TransformOrigin transformOrigin; //Field offset: 0x28
	public Translate translate; //Field offset: 0x3C

	public override TransformData Copy() { }

	public override void CopyFrom(ref TransformData other) { }

	public override bool Equals(TransformData other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TransformData lhs, TransformData rhs) { }

}

