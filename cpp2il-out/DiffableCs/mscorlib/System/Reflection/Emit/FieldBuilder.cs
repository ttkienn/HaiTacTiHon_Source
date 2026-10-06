namespace System.Reflection.Emit;

public sealed class FieldBuilder : FieldInfo
{

	public virtual FieldAttributes Attributes
	{
		 get { } //Length: 9
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 9
	}

	public virtual RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 9
	}

	public virtual Type FieldType
	{
		 get { } //Length: 9
	}

	public virtual string Name
	{
		 get { } //Length: 9
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 9
	}

	public virtual FieldAttributes get_Attributes() { }

	public virtual Type get_DeclaringType() { }

	public virtual RuntimeFieldHandle get_FieldHandle() { }

	public virtual Type get_FieldType() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual object GetValue(object obj) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

