namespace UnityEngine.Internal;

[AttributeUsage(18432)]
public class DefaultValueAttribute : Attribute
{
	private object DefaultValue; //Field offset: 0x10

	public object Value
	{
		 get { } //Length: 7
	}

	public DefaultValueAttribute(string value) { }

	public virtual bool Equals(object obj) { }

	public object get_Value() { }

	public virtual int GetHashCode() { }

}

