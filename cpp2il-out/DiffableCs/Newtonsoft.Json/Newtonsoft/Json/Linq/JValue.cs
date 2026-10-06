namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(2)]
public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
{
	[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
	[NullableContext(1)]
	private class JValueDynamicProxy : DynamicProxy<JValue>
	{

		public JValueDynamicProxy() { }

		public virtual bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result) { }

		public virtual bool TryConvert(JValue instance, ConvertBinder binder, out object result) { }

	}

	private JTokenType _valueType; //Field offset: 0x30
	private object _value; //Field offset: 0x38

	public virtual bool HasValues
	{
		 get { } //Length: 3
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 4
	}

	public object Value
	{
		 get { } //Length: 5
		 set { } //Length: 234
	}

	public JValue(Guid value) { }

	public JValue(object value) { }

	public JValue(TimeSpan value) { }

	public JValue(Uri value) { }

	public JValue(string value) { }

	public JValue(bool value) { }

	public JValue(DateTimeOffset value) { }

	public JValue(float value) { }

	public JValue(DateTime value) { }

	[CLSCompliant(False)]
	public JValue(ulong value) { }

	public JValue(char value) { }

	public JValue(decimal value) { }

	public JValue(long value) { }

	[NullableContext(1)]
	public JValue(JValue other) { }

	[NullableContext(1)]
	internal JValue(JValue other, JsonCloneSettings settings) { }

	internal JValue(object value, JTokenType type) { }

	public JValue(double value) { }

	[NullableContext(1)]
	internal virtual JToken CloneToken(JsonCloneSettings settings) { }

	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	[NullableContext(1)]
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	[NullableContext(1)]
	private static int CompareFloat(object objA, object objB) { }

	public override int CompareTo(JValue obj) { }

	[NullableContext(1)]
	public static JValue CreateComment(string value) { }

	[NullableContext(1)]
	public static JValue CreateNull() { }

	[NullableContext(1)]
	public static JValue CreateString(string value) { }

	[NullableContext(1)]
	public static JValue CreateUndefined() { }

	[NullableContext(1)]
	internal virtual bool DeepEquals(JToken node) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(JValue other) { }

	public virtual bool get_HasValues() { }

	public virtual JTokenType get_Type() { }

	public object get_Value() { }

	internal virtual int GetDeepHashCode() { }

	public virtual int GetHashCode() { }

	[NullableContext(1)]
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	private static bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	public void set_Value(object value) { }

	private override int System.IComparable.CompareTo(object obj) { }

	private override TypeCode System.IConvertible.GetTypeCode() { }

	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[NullableContext(1)]
	private override object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[NullableContext(1)]
	public override string ToString(IFormatProvider formatProvider) { }

	[NullableContext(1)]
	public string ToString(string format) { }

	[NullableContext(1)]
	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	[NullableContext(1)]
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	[NullableContext(1)]
	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[NullableContext(1)]
	public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, JsonConverter[] converters) { }

}

