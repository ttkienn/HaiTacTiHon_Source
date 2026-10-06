namespace System.Net.Configuration;

public sealed class ConnectionManagementSection : ConfigurationSection
{

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 44
	}

	public ConnectionManagementSection() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

