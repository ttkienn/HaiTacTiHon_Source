namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Property (128))]
public class AttributeProviderAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; //Field offset: 0x18

	public string PropertyName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string TypeName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public string get_PropertyName() { }

	[CompilerGenerated]
	public string get_TypeName() { }

}

