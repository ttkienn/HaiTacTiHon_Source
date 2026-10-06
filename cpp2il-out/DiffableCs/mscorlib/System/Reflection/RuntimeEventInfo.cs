namespace System.Reflection;

internal sealed class RuntimeEventInfo : EventInfo, ISerializable
{
	private IntPtr klass; //Field offset: 0x18
	private IntPtr handle; //Field offset: 0x20

	internal BindingFlags BindingFlags
	{
		internal get { } //Length: 375
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 47
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 5
	}

	public virtual Module Module
	{
		 get { } //Length: 35
	}

	public virtual string Name
	{
		 get { } //Length: 47
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 47
	}

	private RuntimeType ReflectedTypeInternal
	{
		private get { } //Length: 125
	}

	public RuntimeEventInfo() { }

	internal BindingFlags get_BindingFlags() { }

	public virtual Type get_DeclaringType() { }

	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	private RuntimeType get_ReflectedTypeInternal() { }

	public virtual MethodInfo GetAddMethod(bool nonPublic) { }

	internal BindingFlags GetBindingFlags() { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	internal RuntimeType GetDeclaringTypeInternal() { }

	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual MethodInfo GetRaiseMethod(bool nonPublic) { }

	public virtual MethodInfo GetRemoveMethod(bool nonPublic) { }

	internal RuntimeModule GetRuntimeModule() { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual string ToString() { }

}

