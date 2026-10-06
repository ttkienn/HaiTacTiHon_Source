namespace System.Data;

internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	private readonly DataColumn <Column>k__BackingField; //Field offset: 0x88

	public virtual AttributeCollection Attributes
	{
		 get { } //Length: 470
	}

	internal DataColumn Column
	{
		[CompilerGenerated]
		internal get { } //Length: 8
	}

	public virtual Type ComponentType
	{
		 get { } //Length: 89
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 30
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 30
	}

	internal DataColumnPropertyDescriptor(DataColumn dataColumn) { }

	public virtual bool CanResetValue(object component) { }

	public virtual bool Equals(object other) { }

	public virtual AttributeCollection get_Attributes() { }

	[CompilerGenerated]
	internal DataColumn get_Column() { }

	public virtual Type get_ComponentType() { }

	public virtual bool get_IsReadOnly() { }

	public virtual Type get_PropertyType() { }

	public virtual int GetHashCode() { }

	public virtual object GetValue(object component) { }

	public virtual void ResetValue(object component) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object component) { }

}

