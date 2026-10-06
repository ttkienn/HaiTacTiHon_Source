namespace System.Runtime.Serialization;

internal sealed class SerializationFieldInfo : FieldInfo
{
	private RuntimeFieldInfo m_field; //Field offset: 0x10
	private string m_serializationName; //Field offset: 0x18

	public virtual FieldAttributes Attributes
	{
		 get { } //Length: 42
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 42
	}

	public virtual RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 42
	}

	internal RuntimeFieldInfo FieldInfo
	{
		internal get { } //Length: 5
	}

	public virtual Type FieldType
	{
		 get { } //Length: 42
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 42
	}

	public virtual Module Module
	{
		 get { } //Length: 42
	}

	public virtual string Name
	{
		 get { } //Length: 5
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 42
	}

	internal SerializationFieldInfo(RuntimeFieldInfo field, string namePrefix) { }

	public virtual FieldAttributes get_Attributes() { }

	public virtual Type get_DeclaringType() { }

	public virtual RuntimeFieldHandle get_FieldHandle() { }

	internal RuntimeFieldInfo get_FieldInfo() { }

	public virtual Type get_FieldType() { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual object GetValue(object obj) { }

	internal object InternalGetValue(object obj) { }

	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

