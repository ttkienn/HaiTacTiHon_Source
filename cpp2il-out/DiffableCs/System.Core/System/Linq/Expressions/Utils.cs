namespace System.Linq.Expressions;

internal static class Utils
{
	public static readonly object BoxedFalse; //Field offset: 0x0
	public static readonly object BoxedTrue; //Field offset: 0x8
	public static readonly object BoxedIntM1; //Field offset: 0x10
	public static readonly object BoxedInt0; //Field offset: 0x18
	public static readonly object BoxedInt1; //Field offset: 0x20
	public static readonly object BoxedInt2; //Field offset: 0x28
	public static readonly object BoxedInt3; //Field offset: 0x30
	public static readonly object BoxedDefaultSByte; //Field offset: 0x38
	public static readonly object BoxedDefaultChar; //Field offset: 0x40
	public static readonly object BoxedDefaultInt16; //Field offset: 0x48
	public static readonly object BoxedDefaultInt64; //Field offset: 0x50
	public static readonly object BoxedDefaultByte; //Field offset: 0x58
	public static readonly object BoxedDefaultUInt16; //Field offset: 0x60
	public static readonly object BoxedDefaultUInt32; //Field offset: 0x68
	public static readonly object BoxedDefaultUInt64; //Field offset: 0x70
	public static readonly object BoxedDefaultSingle; //Field offset: 0x78
	public static readonly object BoxedDefaultDouble; //Field offset: 0x80
	public static readonly object BoxedDefaultDecimal; //Field offset: 0x88
	public static readonly object BoxedDefaultDateTime; //Field offset: 0x90
	private static readonly ConstantExpression s_true; //Field offset: 0x98
	private static readonly ConstantExpression s_false; //Field offset: 0xA0
	private static readonly ConstantExpression s_m1; //Field offset: 0xA8
	private static readonly ConstantExpression s_0; //Field offset: 0xB0
	private static readonly ConstantExpression s_1; //Field offset: 0xB8
	private static readonly ConstantExpression s_2; //Field offset: 0xC0
	private static readonly ConstantExpression s_3; //Field offset: 0xC8
	public static readonly DefaultExpression Empty; //Field offset: 0xD0
	public static readonly ConstantExpression Null; //Field offset: 0xD8

	private static Utils() { }

	public static ConstantExpression Constant(int value) { }

	public static ConstantExpression Constant(bool value) { }

}

