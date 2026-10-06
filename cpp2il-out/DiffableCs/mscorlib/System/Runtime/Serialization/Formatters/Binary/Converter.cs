namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class Converter
{
	private static int primitiveTypeEnumLength; //Field offset: 0x0
	private static Type[] typeA; //Field offset: 0x8
	private static Type[] arrayTypeA; //Field offset: 0x10
	private static String[] valueA; //Field offset: 0x18
	private static TypeCode[] typeCodeA; //Field offset: 0x20
	private static InternalPrimitiveTypeE[] codeA; //Field offset: 0x28
	internal static Type typeofISerializable; //Field offset: 0x30
	internal static Type typeofString; //Field offset: 0x38
	internal static Type typeofConverter; //Field offset: 0x40
	internal static Type typeofBoolean; //Field offset: 0x48
	internal static Type typeofByte; //Field offset: 0x50
	internal static Type typeofChar; //Field offset: 0x58
	internal static Type typeofDecimal; //Field offset: 0x60
	internal static Type typeofDouble; //Field offset: 0x68
	internal static Type typeofInt16; //Field offset: 0x70
	internal static Type typeofInt32; //Field offset: 0x78
	internal static Type typeofInt64; //Field offset: 0x80
	internal static Type typeofSByte; //Field offset: 0x88
	internal static Type typeofSingle; //Field offset: 0x90
	internal static Type typeofTimeSpan; //Field offset: 0x98
	internal static Type typeofDateTime; //Field offset: 0xA0
	internal static Type typeofUInt16; //Field offset: 0xA8
	internal static Type typeofUInt32; //Field offset: 0xB0
	internal static Type typeofUInt64; //Field offset: 0xB8
	internal static Type typeofObject; //Field offset: 0xC0
	internal static Type typeofSystemVoid; //Field offset: 0xC8
	internal static Assembly urtAssembly; //Field offset: 0xD0
	internal static string urtAssemblyString; //Field offset: 0xD8
	internal static Type typeofTypeArray; //Field offset: 0xE0
	internal static Type typeofObjectArray; //Field offset: 0xE8
	internal static Type typeofStringArray; //Field offset: 0xF0
	internal static Type typeofBooleanArray; //Field offset: 0xF8
	internal static Type typeofByteArray; //Field offset: 0x100
	internal static Type typeofCharArray; //Field offset: 0x108
	internal static Type typeofDecimalArray; //Field offset: 0x110
	internal static Type typeofDoubleArray; //Field offset: 0x118
	internal static Type typeofInt16Array; //Field offset: 0x120
	internal static Type typeofInt32Array; //Field offset: 0x128
	internal static Type typeofInt64Array; //Field offset: 0x130
	internal static Type typeofSByteArray; //Field offset: 0x138
	internal static Type typeofSingleArray; //Field offset: 0x140
	internal static Type typeofTimeSpanArray; //Field offset: 0x148
	internal static Type typeofDateTimeArray; //Field offset: 0x150
	internal static Type typeofUInt16Array; //Field offset: 0x158
	internal static Type typeofUInt32Array; //Field offset: 0x160
	internal static Type typeofUInt64Array; //Field offset: 0x168
	internal static Type typeofMarshalByRefObject; //Field offset: 0x170

	private static Converter() { }

	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	private static void InitArrayTypeA() { }

	private static void InitCodeA() { }

	private static void InitTypeA() { }

	private static void InitTypeCodeA() { }

	private static void InitValueA() { }

	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	internal static string ToComType(InternalPrimitiveTypeE code) { }

	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	internal static Type ToType(InternalPrimitiveTypeE code) { }

	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	internal static int TypeLength(InternalPrimitiveTypeE code) { }

}

