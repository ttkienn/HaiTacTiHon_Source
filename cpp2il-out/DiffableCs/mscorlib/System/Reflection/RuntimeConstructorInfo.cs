namespace System.Reflection;

internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable
{
	internal IntPtr mhandle; //Field offset: 0x10
	private string name; //Field offset: 0x18
	private Type reftype; //Field offset: 0x20

	public virtual MethodAttributes Attributes
	{
		 get { } //Length: 9
	}

	internal BindingFlags BindingFlags
	{
		internal get { } //Length: 3
	}

	public virtual CallingConventions CallingConvention
	{
		 get { } //Length: 40
	}

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 60
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 41
	}

	public virtual bool IsSecurityCritical
	{
		 get { } //Length: 3
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 5
	}

	public virtual RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 5
	}

	public virtual Module Module
	{
		 get { } //Length: 143
	}

	public virtual string Name
	{
		 get { } //Length: 16
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 5
	}

	private RuntimeType ReflectedTypeInternal
	{
		private get { } //Length: 125
	}

	public RuntimeConstructorInfo() { }

	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public virtual MethodAttributes get_Attributes() { }

	internal BindingFlags get_BindingFlags() { }

	public virtual CallingConventions get_CallingConvention() { }

	public virtual bool get_ContainsGenericParameters() { }

	private static int get_core_clr_security_level() { }

	public virtual Type get_DeclaringType() { }

	public virtual bool get_IsSecurityCritical() { }

	internal static int get_metadata_token(RuntimeConstructorInfo method) { }

	public virtual int get_MetadataToken() { }

	public virtual RuntimeMethodHandle get_MethodHandle() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual ParameterInfo[] GetParameters() { }

	internal virtual int GetParametersCount() { }

	internal virtual ParameterInfo[] GetParametersInternal() { }

	internal RuntimeModule GetRuntimeModule() { }

	public object InternalInvoke(object obj, Object[] parameters, bool wrapExceptions) { }

	internal object InternalInvoke(object obj, Object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	internal string SerializationToString() { }

	public virtual string ToString() { }

}

