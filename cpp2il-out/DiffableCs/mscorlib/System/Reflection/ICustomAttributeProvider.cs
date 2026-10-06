namespace System.Reflection;

public interface ICustomAttributeProvider
{

	public Object[] GetCustomAttributes(bool inherit) { }

	public Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public bool IsDefined(Type attributeType, bool inherit) { }

}

