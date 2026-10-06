namespace System.Text;

public sealed class EncoderExceptionFallback : EncoderFallback
{

	public virtual int MaxCharCount
	{
		 get { } //Length: 3
	}

	public EncoderExceptionFallback() { }

	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	public virtual bool Equals(object value) { }

	public virtual int get_MaxCharCount() { }

	public virtual int GetHashCode() { }

}

