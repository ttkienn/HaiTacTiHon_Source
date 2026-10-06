namespace System.Reflection;

internal class RuntimeFieldInfo : RtFieldInfo, ISerializable
{
	internal IntPtr klass; //Field offset: 0x10
	internal RuntimeFieldHandle fhandle; //Field offset: 0x18
	private string name; //Field offset: 0x20
	private Type type; //Field offset: 0x28
	private FieldAttributes attrs; //Field offset: 0x30

	public virtual FieldAttributes Attributes
	{
		 get { } //Length: 4
	}

	internal BindingFlags BindingFlags
	{
		internal get { } //Length: 3
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 7
	}

	public virtual RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 5
	}

	public virtual Type FieldType
	{
		 get { } //Length: 122
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 5
	}

	public virtual Module Module
	{
		 get { } //Length: 137
	}

	public virtual string Name
	{
		 get { } //Length: 5
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 7
	}

	private RuntimeType ReflectedTypeInternal
	{
		private get { } //Length: 125
	}

	public RuntimeFieldInfo() { }

	internal virtual void CheckConsistency(object target) { }

	private void CheckGeneric() { }

	public virtual FieldAttributes get_Attributes() { }

	internal BindingFlags get_BindingFlags() { }

	public virtual Type get_DeclaringType() { }

	public virtual RuntimeFieldHandle get_FieldHandle() { }

	public virtual Type get_FieldType() { }

	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	internal RuntimeType GetDeclaringTypeInternal() { }

	internal virtual int GetFieldOffset() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private Type GetParentType(bool declaring) { }

	public virtual object GetRawConstantValue() { }

	internal RuntimeModule GetRuntimeModule() { }

	public virtual object GetValue(object obj) { }

	private object GetValueInternal(object obj) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	private Type ResolveType() { }

	public virtual void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	public virtual string ToString() { }

	internal virtual object UnsafeGetValue(object obj) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	internal virtual void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

