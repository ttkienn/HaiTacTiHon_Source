namespace System.Runtime.Serialization;

public class FormatterConverter : IFormatterConverter
{

	public FormatterConverter() { }

	public override object Convert(object value, Type type) { }

	private static void ThrowValueNullException() { }

	public override bool ToBoolean(object value) { }

	public override int ToInt32(object value) { }

	public override long ToInt64(object value) { }

	public override float ToSingle(object value) { }

	public override string ToString(object value) { }

}

