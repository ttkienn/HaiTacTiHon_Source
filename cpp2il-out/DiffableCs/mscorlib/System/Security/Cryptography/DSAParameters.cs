namespace System.Security.Cryptography;

[ComVisible(True)]
public struct DSAParameters
{
	public Byte[] P; //Field offset: 0x0
	public Byte[] Q; //Field offset: 0x8
	public Byte[] G; //Field offset: 0x10
	public Byte[] Y; //Field offset: 0x18
	public Byte[] J; //Field offset: 0x20
	public Byte[] X; //Field offset: 0x28
	public Byte[] Seed; //Field offset: 0x30
	public int Counter; //Field offset: 0x38

}

