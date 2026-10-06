namespace System.Diagnostics;

[AttributeUsage(AttributeTargets::Class (4))]
public sealed class SwitchLevelAttribute : Attribute
{
	private Type type; //Field offset: 0x10

	public Type SwitchLevelType
	{
		 set { } //Length: 180
	}

	public SwitchLevelAttribute(Type switchLevelType) { }

	public void set_SwitchLevelType(Type value) { }

}

