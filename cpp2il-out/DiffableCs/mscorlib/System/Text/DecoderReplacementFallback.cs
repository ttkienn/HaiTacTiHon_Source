namespace System.Text;

public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable
{
	private string _strDefault; //Field offset: 0x10

	public string DefaultString
	{
		 get { } //Length: 5
	}

	public virtual int MaxCharCount
	{
		 get { } //Length: 26
	}

	public DecoderReplacementFallback() { }

	internal DecoderReplacementFallback(SerializationInfo info, StreamingContext context) { }

	public DecoderReplacementFallback(string replacement) { }

	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	public virtual bool Equals(object value) { }

	public string get_DefaultString() { }

	public virtual int get_MaxCharCount() { }

	public virtual int GetHashCode() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

