namespace System.Runtime.Serialization;

public interface IObjectReference
{

	public object GetRealObject(StreamingContext context) { }

}

