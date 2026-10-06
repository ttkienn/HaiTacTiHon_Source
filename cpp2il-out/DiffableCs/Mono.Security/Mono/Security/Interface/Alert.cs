namespace Mono.Security.Interface;

public class Alert
{
	private AlertLevel level; //Field offset: 0x10
	private AlertDescription description; //Field offset: 0x11

	public AlertDescription Description
	{
		 get { } //Length: 5
	}

	public AlertLevel Level
	{
		 get { } //Length: 5
	}

	public Alert(AlertDescription description) { }

	public AlertDescription get_Description() { }

	public AlertLevel get_Level() { }

	private void inferAlertLevel() { }

	public virtual string ToString() { }

}

