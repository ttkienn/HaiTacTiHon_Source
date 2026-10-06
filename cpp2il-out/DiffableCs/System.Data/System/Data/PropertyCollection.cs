namespace System.Data;

public class PropertyCollection : Hashtable, ICloneable
{

	public PropertyCollection() { }

	protected PropertyCollection(SerializationInfo info, StreamingContext context) { }

	public virtual object Clone() { }

}

