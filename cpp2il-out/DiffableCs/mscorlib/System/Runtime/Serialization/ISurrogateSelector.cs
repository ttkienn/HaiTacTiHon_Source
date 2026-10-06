namespace System.Runtime.Serialization;

public interface ISurrogateSelector
{

	public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector) { }

}

