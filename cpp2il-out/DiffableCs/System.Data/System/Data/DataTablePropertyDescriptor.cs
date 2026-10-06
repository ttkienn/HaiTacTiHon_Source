namespace System.Data;

internal sealed class DataTablePropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; //Field offset: 0x88

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

	public DataTable Table
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual bool CanResetValue(object component) { }

	public virtual Type get_ComponentType() { }

	public virtual bool get_IsReadOnly() { }

	public virtual Type get_PropertyType() { }

	[CompilerGenerated]
	public DataTable get_Table() { }

	public virtual object GetValue(object component) { }

	public virtual void ResetValue(object component) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object component) { }

}

