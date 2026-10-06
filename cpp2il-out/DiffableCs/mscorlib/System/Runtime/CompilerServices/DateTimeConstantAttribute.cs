namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute
{
	private DateTime _date; //Field offset: 0x10

	public virtual object Value
	{
		 get { } //Length: 69
	}

	public virtual object get_Value() { }

}

