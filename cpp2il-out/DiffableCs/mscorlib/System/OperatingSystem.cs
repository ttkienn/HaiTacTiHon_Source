namespace System;

public sealed class OperatingSystem : ISerializable, ICloneable
{
	private readonly Version _version; //Field offset: 0x10
	private readonly PlatformID _platform; //Field offset: 0x18
	private readonly string _servicePack; //Field offset: 0x20
	private string _versionString; //Field offset: 0x28

	public PlatformID Platform
	{
		 get { } //Length: 4
	}

	public Version Version
	{
		 get { } //Length: 5
	}

	public string VersionString
	{
		 get { } //Length: 500
	}

	public OperatingSystem(PlatformID platform, Version version) { }

	internal OperatingSystem(PlatformID platform, Version version, string servicePack) { }

	public override object Clone() { }

	public PlatformID get_Platform() { }

	public Version get_Version() { }

	public string get_VersionString() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

