namespace System.Reflection.Emit;

public sealed class PropertyBuilder : PropertyInfo
{

	public virtual bool CanRead
	{
		 get { } //Length: 62
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 62
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 62
	}

	public virtual string Name
	{
		 get { } //Length: 62
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 62
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 62
	}

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual Type get_DeclaringType() { }

	public virtual string get_Name() { }

	public virtual Type get_PropertyType() { }

	public virtual Type get_ReflectedType() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual MethodInfo GetGetMethod(bool nonPublic) { }

	public virtual ParameterInfo[] GetIndexParameters() { }

	public virtual MethodInfo GetSetMethod(bool nonPublic) { }

	public virtual object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

}

