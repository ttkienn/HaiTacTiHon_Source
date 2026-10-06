namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class DES : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	public virtual Byte[] Key
	{
		 get { } //Length: 241
		 set { } //Length: 679
	}

	private static DES() { }

	protected DES() { }

	public static DES Create() { }

	public virtual Byte[] get_Key() { }

	private static bool IsLegalKeySize(Byte[] rgbKey) { }

	public static bool IsSemiWeakKey(Byte[] rgbKey) { }

	public static bool IsWeakKey(Byte[] rgbKey) { }

	private static ulong QuadWordFromBigEndian(Byte[] block) { }

	public virtual void set_Key(Byte[] value) { }

}

