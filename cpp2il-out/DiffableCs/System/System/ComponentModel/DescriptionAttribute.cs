namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public class DescriptionAttribute : Attribute
{
	public static readonly DescriptionAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	private string <DescriptionValue>k__BackingField; //Field offset: 0x10

	public override string Description
	{
		 get { } //Length: 5
	}

	protected string DescriptionValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	private static DescriptionAttribute() { }

	public DescriptionAttribute() { }

	public DescriptionAttribute(string description) { }

	public virtual bool Equals(object obj) { }

	public override string get_Description() { }

	[CompilerGenerated]
	protected string get_DescriptionValue() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

	[CompilerGenerated]
	protected void set_DescriptionValue(string value) { }

}

