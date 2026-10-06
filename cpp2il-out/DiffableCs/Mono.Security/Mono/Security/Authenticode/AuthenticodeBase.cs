namespace Mono.Security.Authenticode;

public class AuthenticodeBase
{
	private Byte[] fileblock; //Field offset: 0x10
	private Stream fs; //Field offset: 0x18
	private int blockNo; //Field offset: 0x20
	private int blockLength; //Field offset: 0x24
	private int peOffset; //Field offset: 0x28
	private int dirSecurityOffset; //Field offset: 0x2C
	private int dirSecuritySize; //Field offset: 0x30
	private int coffSymbolTableOffset; //Field offset: 0x34
	private bool pe64; //Field offset: 0x38

	internal int PEOffset
	{
		internal get { } //Length: 40
	}

	public AuthenticodeBase() { }

	internal void Close() { }

	internal int get_PEOffset() { }

	internal Byte[] GetHash(HashAlgorithm hash) { }

	internal Byte[] GetSecurityEntry() { }

	internal void Open(string filename) { }

	internal void Open(Byte[] rawdata) { }

	internal int ProcessFirstBlock() { }

	internal void ReadFirstBlock() { }

}

