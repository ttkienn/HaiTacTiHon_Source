namespace System;

internal class DefaultBinder : Binder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Type> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SelectProperty>b__2_0(Type t) { }

	}

	public class BinderState
	{
		internal Int32[] m_argsMap; //Field offset: 0x10
		internal int m_originalSize; //Field offset: 0x18
		internal bool m_isParamArray; //Field offset: 0x1C

		internal BinderState(Int32[] argsMap, int originalSize, bool isParamArray) { }

	}

	[Flags]
	private enum Primitives
	{
		Boolean = 8,
		Char = 16,
		SByte = 32,
		Byte = 64,
		Int16 = 128,
		UInt16 = 256,
		Int32 = 512,
		UInt32 = 1024,
		Int64 = 2048,
		UInt64 = 4096,
		Single = 8192,
		Double = 16384,
		Decimal = 32768,
		DateTime = 65536,
		String = 262144,
	}

	private static Primitives[] _primitiveConversions; //Field offset: 0x0

	private static DefaultBinder() { }

	public DefaultBinder() { }

	public virtual FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	public virtual MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref Object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, String[] names, out object state) { }

	private static bool CanChangePrimitive(Type source, Type target) { }

	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	private static bool CanPrimitiveWiden(Type source, Type target) { }

	public virtual object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	internal static bool CompareMethodSig(MethodBase m1, MethodBase m2) { }

	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	private static bool CreateParamOrder(Int32[] paramOrder, ParameterInfo[] pars, String[] names) { }

	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	private static int FindMostSpecific(ParameterInfo[] p1, Int32[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, Int32[] paramOrder2, Type paramArrayType2, Type[] types, Object[] args) { }

	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	private static int FindMostSpecificMethod(MethodBase m1, Int32[] paramOrder1, Type paramArrayType1, MethodBase m2, Int32[] paramOrder2, Type paramArrayType2, Type[] types, Object[] args) { }

	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	internal static int GetHierarchyDepth(Type t) { }

	public virtual void ReorderArgumentArray(ref Object[] args, object state) { }

	private static void ReorderParams(Int32[] paramOrder, Object[] vars) { }

	public virtual MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	public virtual PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

}

