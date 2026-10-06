namespace System.Reflection;

internal class RuntimePropertyInfo : PropertyInfo, ISerializable
{
	private sealed class Getter : MulticastDelegate
	{

		public Getter`2(object object, IntPtr method) { }

		public override R Invoke(T _this) { }

	}

	private sealed class GetterAdapter : MulticastDelegate
	{

		public GetterAdapter(object object, IntPtr method) { }

		public override object Invoke(object _this) { }

	}

	private sealed class StaticGetter : MulticastDelegate
	{

		public StaticGetter`1(object object, IntPtr method) { }

		public override R Invoke() { }

	}

	internal IntPtr klass; //Field offset: 0x10
	internal IntPtr prop; //Field offset: 0x18
	private MonoPropertyInfo info; //Field offset: 0x20
	private PInfo cached; //Field offset: 0x50
	private GetterAdapter cached_getter; //Field offset: 0x58

	internal BindingFlags BindingFlags
	{
		internal get { } //Length: 3
	}

	public virtual bool CanRead
	{
		 get { } //Length: 53
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 53
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 54
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
		 get { } //Length: 54
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 181
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 54
	}

	private RuntimeType ReflectedTypeInternal
	{
		private get { } //Length: 125
	}

	public RuntimePropertyInfo() { }

	private void CachePropertyInfo(PInfo flags) { }

	private string FormatNameAndSig(bool serialization) { }

	internal BindingFlags get_BindingFlags() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual Type get_DeclaringType() { }

	internal static int get_metadata_token(RuntimePropertyInfo monoProperty) { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info) { }

	public virtual Type get_PropertyType() { }

	public virtual Type get_ReflectedType() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	internal RuntimeType GetDeclaringTypeInternal() { }

	public virtual MethodInfo GetGetMethod(bool nonPublic) { }

	public virtual ParameterInfo[] GetIndexParameters() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	internal RuntimeModule GetRuntimeModule() { }

	public virtual MethodInfo GetSetMethod(bool nonPublic) { }

	private static object GetterAdapterFrame(Getter<T, R> getter, object obj) { }

	public virtual object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	public virtual object GetValue(object obj, Object[] index) { }

	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	internal string SerializationToString() { }

	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	private static object StaticGetterAdapterFrame(StaticGetter<R> getter, object obj) { }

	public virtual string ToString() { }

}

