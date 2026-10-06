namespace System.Xml;

internal interface IValidationEventHandling
{

	public object EventHandler
	{
		 get { } //Length: 0
	}

	public object get_EventHandler() { }

	public void SendEvent(Exception exception, XmlSeverityType severity) { }

}

