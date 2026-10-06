namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class RC2 : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8
	protected int EffectiveKeySizeValue; //Field offset: 0x48

	public override int EffectiveKeySize
	{
		 get { } //Length: 14
	}

	public virtual int KeySize
	{
		 get { } //Length: 4
		 set { } //Length: 126
	}

	private static RC2() { }

	protected RC2() { }

	public override int get_EffectiveKeySize() { }

	public virtual int get_KeySize() { }

	public virtual void set_KeySize(int value) { }

}

