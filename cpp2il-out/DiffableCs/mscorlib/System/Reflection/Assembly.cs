namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	public class ResolveEventHolder
	{

		public ResolveEventHolder() { }

	}


	public override string CodeBase
	{
		 get { } //Length: 62
	}

	public override string FullName
	{
		 get { } //Length: 62
	}

	[MonoTODO]
	public bool IsFullyTrusted
	{
		 get { } //Length: 3
	}

	public override string Location
	{
		 get { } //Length: 62
	}

	internal override IntPtr MonoAssembly
	{
		internal get { } //Length: 62
	}

	public Assembly() { }

	private static Exception CreateNIE() { }

	public virtual bool Equals(object o) { }

	public override string get_CodeBase() { }

	public override string get_FullName() { }

	public bool get_IsFullyTrusted() { }

	public override string get_Location() { }

	internal override IntPtr get_MonoAssembly() { }

	public static Assembly GetAssembly(Type type) { }

	public static Assembly GetCallingAssembly() { }

	public override Object[] GetCustomAttributes(bool inherit) { }

	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public static Assembly GetExecutingAssembly() { }

	public virtual int GetHashCode() { }

	public override Module GetModule(string name) { }

	public override Module[] GetModules(bool getResourceModules) { }

	internal override Module[] GetModulesInternal() { }

	public override AssemblyName GetName(bool copiedName) { }

	public override AssemblyName GetName() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override Type GetType(string name) { }

	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	internal override Type[] GetTypes(bool exportedOnly) { }

	public override Type[] GetTypes() { }

	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public static Assembly Load(string assemblyString) { }

	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName) { }

	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	public static bool op_Equality(Assembly left, Assembly right) { }

	public static bool op_Inequality(Assembly left, Assembly right) { }

	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	public virtual string ToString() { }

}

