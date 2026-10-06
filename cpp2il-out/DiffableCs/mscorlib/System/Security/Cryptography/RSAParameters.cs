namespace System.Security.Cryptography;

[ComVisible(True)]
public struct RSAParameters
{
	public Byte[] Exponent; //Field offset: 0x0
	public Byte[] Modulus; //Field offset: 0x8
	public Byte[] P; //Field offset: 0x10
	public Byte[] Q; //Field offset: 0x18
	public Byte[] DP; //Field offset: 0x20
	public Byte[] DQ; //Field offset: 0x28
	public Byte[] InverseQ; //Field offset: 0x30
	public Byte[] D; //Field offset: 0x38

}

