namespace System.Timers;

[AttributeUsage(AttributeTargets::All (32767))]
public class TimersDescriptionAttribute : DescriptionAttribute
{
	private bool replaced; //Field offset: 0x18

	public virtual string Description
	{
		 get { } //Length: 67
	}

	public TimersDescriptionAttribute(string description) { }

	public virtual string get_Description() { }

}

