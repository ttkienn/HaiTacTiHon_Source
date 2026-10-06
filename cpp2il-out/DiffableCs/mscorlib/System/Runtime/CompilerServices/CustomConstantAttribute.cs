namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
public abstract class CustomConstantAttribute : Attribute
{

	public abstract object Value
	{
		 get { } //Length: 0
	}

	protected CustomConstantAttribute() { }

	public abstract object get_Value() { }

}

