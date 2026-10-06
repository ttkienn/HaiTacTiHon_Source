namespace System.Security.Cryptography;

public sealed class AesManaged : Aes
{
	private RijndaelManaged m_rijndael; //Field offset: 0x48

	public virtual int FeedbackSize
	{
		 get { } //Length: 42
	}

	public virtual Byte[] IV
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual Byte[] Key
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual int KeySize
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public virtual CipherMode Mode
	{
		 get { } //Length: 42
		 set { } //Length: 161
	}

	public virtual PaddingMode Padding
	{
		 get { } //Length: 42
		 set { } //Length: 42
	}

	public AesManaged() { }

	public virtual ICryptoTransform CreateDecryptor(Byte[] key, Byte[] iv) { }

	public virtual ICryptoTransform CreateDecryptor() { }

	public virtual ICryptoTransform CreateEncryptor(Byte[] key, Byte[] iv) { }

	public virtual ICryptoTransform CreateEncryptor() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

	public virtual int get_FeedbackSize() { }

	public virtual Byte[] get_IV() { }

	public virtual Byte[] get_Key() { }

	public virtual int get_KeySize() { }

	public virtual CipherMode get_Mode() { }

	public virtual PaddingMode get_Padding() { }

	public virtual void set_IV(Byte[] value) { }

	public virtual void set_Key(Byte[] value) { }

	public virtual void set_KeySize(int value) { }

	public virtual void set_Mode(CipherMode value) { }

	public virtual void set_Padding(PaddingMode value) { }

}

