namespace System.Data;

internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	private readonly DataRelation <Relation>k__BackingField; //Field offset: 0x88

	public virtual Type ComponentType
	{
		 get { } //Length: 89
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 89
	}

	internal DataRelation Relation
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	internal DataRelationPropertyDescriptor(DataRelation dataRelation) { }

	public virtual bool CanResetValue(object component) { }

	public virtual bool Equals(object other) { }

	public virtual Type get_ComponentType() { }

	public virtual bool get_IsReadOnly() { }

	public virtual Type get_PropertyType() { }

	[CompilerGenerated]
	internal DataRelation get_Relation() { }

	public virtual int GetHashCode() { }

	public virtual object GetValue(object component) { }

	public virtual void ResetValue(object component) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object component) { }

}

