namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
public sealed class DecimalConstantAttribute : Attribute
{
	private decimal _dec; //Field offset: 0x10

	public decimal Value
	{
		 get { } //Length: 11
	}

	[CLSCompliant(False)]
	public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) { }

	public decimal get_Value() { }

}

