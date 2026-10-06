namespace System.Runtime.Remoting;

internal class EnvoyInfo : IEnvoyInfo
{
	private IMessageSink envoySinks; //Field offset: 0x10

	public override IMessageSink EnvoySinks
	{
		 get { } //Length: 5
	}

	public EnvoyInfo(IMessageSink sinks) { }

	public override IMessageSink get_EnvoySinks() { }

}

