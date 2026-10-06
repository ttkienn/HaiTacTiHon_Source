namespace System;

[ComVisible(True)]
public struct RuntimeTypeHandle : ISerializable
{
	private IntPtr value; //Field offset: 0x0

	public IntPtr Value
	{
		 get { } //Length: 4
	}

	internal RuntimeTypeHandle(IntPtr val) { }

	internal RuntimeTypeHandle(RuntimeType type) { }

	private RuntimeTypeHandle(SerializationInfo info, StreamingContext context) { }

	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public virtual bool Equals(object obj) { }

	public IntPtr get_Value() { }

	internal static int GetArrayRank(RuntimeType type) { }

	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	internal static RuntimeType GetBaseType(RuntimeType type) { }

	internal static CorElementType GetCorElementType(RuntimeType type) { }

	internal static RuntimeType GetElementType(RuntimeType type) { }

	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	public virtual int GetHashCode() { }

	private static int GetMetadataToken(RuntimeType type) { }

	internal static RuntimeModule GetModule(RuntimeType type) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal static int GetToken(RuntimeType type) { }

	internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName) { }

	internal static bool HasElementType(RuntimeType type) { }

	internal static bool HasInstantiation(RuntimeType type) { }

	internal static bool HasReferences(RuntimeType type) { }

	private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly) { }

	internal static bool is_subclass_of(IntPtr childType, IntPtr baseType) { }

	internal static bool IsArray(RuntimeType type) { }

	internal static bool IsByRef(RuntimeType type) { }

	internal static bool IsComObject(RuntimeType type) { }

	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	internal static bool IsContextful(RuntimeType type) { }

	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	internal static bool IsGenericVariable(RuntimeType type) { }

	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	internal static bool IsInterface(RuntimeType type) { }

	internal static bool IsPointer(RuntimeType type) { }

	internal static bool IsPrimitive(RuntimeType type) { }

	internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType) { }

	internal static bool IsSzArray(RuntimeType type) { }

	private static bool type_is_assignable_from(Type a, Type b) { }

}

