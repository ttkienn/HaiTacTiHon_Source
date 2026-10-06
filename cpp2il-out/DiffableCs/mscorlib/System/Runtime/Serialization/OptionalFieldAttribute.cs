namespace System.Runtime.Serialization;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[ComVisible(True)]
public sealed class OptionalFieldAttribute : Attribute
{
	private int versionAdded; //Field offset: 0x10

	public int VersionAdded
	{
		 set { } //Length: 122
	}

	public OptionalFieldAttribute() { }

	public void set_VersionAdded(int value) { }

}

