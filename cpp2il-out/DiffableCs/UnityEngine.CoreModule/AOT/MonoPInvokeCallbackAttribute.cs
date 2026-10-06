namespace AOT;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
public class MonoPInvokeCallbackAttribute : Attribute
{

	public MonoPInvokeCallbackAttribute(Type type) { }

}

