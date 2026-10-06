namespace System.Text;

public sealed class DecoderExceptionFallback : DecoderFallback
{

	public virtual int MaxCharCount
	{
		 get { } //Length: 3
	}

	public DecoderExceptionFallback() { }

	public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

	public virtual bool Equals(object value) { }

	public virtual int get_MaxCharCount() { }

	public virtual int GetHashCode() { }

}

