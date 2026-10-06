namespace System.Globalization;

public class CultureNotFoundException : ArgumentException
{
	private string _invalidCultureName; //Field offset: 0x98
	private Nullable<Int32> _invalidCultureId; //Field offset: 0xA0

	private static string DefaultMessage
	{
		private get { } //Length: 44
	}

	private string FormatedInvalidCultureId
	{
		private get { } //Length: 282
	}

	public override Nullable<Int32> InvalidCultureId
	{
		 get { } //Length: 8
	}

	public override string InvalidCultureName
	{
		 get { } //Length: 8
	}

	public virtual string Message
	{
		 get { } //Length: 409
	}

	public CultureNotFoundException() { }

	public CultureNotFoundException(string paramName, string message) { }

	protected CultureNotFoundException(SerializationInfo info, StreamingContext context) { }

	private static string get_DefaultMessage() { }

	private string get_FormatedInvalidCultureId() { }

	public override Nullable<Int32> get_InvalidCultureId() { }

	public override string get_InvalidCultureName() { }

	public virtual string get_Message() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

