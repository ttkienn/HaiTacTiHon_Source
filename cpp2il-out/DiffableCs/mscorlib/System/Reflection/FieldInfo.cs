namespace System.Reflection;

public abstract class FieldInfo : MemberInfo
{

	public abstract FieldAttributes Attributes
	{
		 get { } //Length: 0
	}

	public abstract RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 0
	}

	public abstract Type FieldType
	{
		 get { } //Length: 0
	}

	public override bool IsInitOnly
	{
		 get { } //Length: 33
	}

	public override bool IsLiteral
	{
		 get { } //Length: 33
	}

	public override bool IsNotSerialized
	{
		 get { } //Length: 36
	}

	public override bool IsPrivate
	{
		 get { } //Length: 35
	}

	public override bool IsPublic
	{
		 get { } //Length: 36
	}

	public override bool IsStatic
	{
		 get { } //Length: 33
	}

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 6
	}

	protected FieldInfo() { }

	public virtual bool Equals(object obj) { }

	public abstract FieldAttributes get_Attributes() { }

	public abstract RuntimeFieldHandle get_FieldHandle() { }

	public abstract Type get_FieldType() { }

	public override bool get_IsInitOnly() { }

	public override bool get_IsLiteral() { }

	public override bool get_IsNotSerialized() { }

	public override bool get_IsPrivate() { }

	public override bool get_IsPublic() { }

	public override bool get_IsStatic() { }

	private MarshalAsAttribute get_marshal_info() { }

	public virtual MemberTypes get_MemberType() { }

	[ComVisible(False)]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	internal override int GetFieldOffset() { }

	public virtual int GetHashCode() { }

	internal Object[] GetPseudoCustomAttributes() { }

	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	public override object GetRawConstantValue() { }

	public abstract object GetValue(object obj) { }

	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public override void SetValue(object obj, object value) { }

	[CLSCompliant(False)]
	public override void SetValueDirect(TypedReference obj, object value) { }

}

