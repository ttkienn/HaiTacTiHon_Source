namespace System.Data;

[IsReadOnly]
internal struct IndexField
{
	public readonly DataColumn Column; //Field offset: 0x0
	public readonly bool IsDescending; //Field offset: 0x8

	internal IndexField(DataColumn column, bool isDescending) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(IndexField if1, IndexField if2) { }

}

