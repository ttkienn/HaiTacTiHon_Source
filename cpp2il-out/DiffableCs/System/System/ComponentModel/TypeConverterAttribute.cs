namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class TypeConverterAttribute : Attribute
{
	public static readonly TypeConverterAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <ConverterTypeName>k__BackingField; //Field offset: 0x10

	public string ConverterTypeName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static TypeConverterAttribute() { }

	public TypeConverterAttribute() { }

	public TypeConverterAttribute(Type type) { }

	public TypeConverterAttribute(string typeName) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_ConverterTypeName() { }

	public virtual int GetHashCode() { }

}

