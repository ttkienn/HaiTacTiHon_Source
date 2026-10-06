namespace Unity.Services.Core.Configuration;

internal struct SerializableProjectConfiguration
{
	[JsonRequired]
	[SerializeField]
	internal String[] Keys; //Field offset: 0x0
	[JsonRequired]
	[SerializeField]
	internal ConfigurationEntry[] Values; //Field offset: 0x8

	public static SerializableProjectConfiguration Empty
	{
		 get { } //Length: 118
	}

	public static SerializableProjectConfiguration get_Empty() { }

}

