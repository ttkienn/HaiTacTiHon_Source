namespace System.Security.Cryptography;

public sealed class AesCryptoServiceProvider : Aes
{

	public virtual int FeedbackSize
	{
		 get { } //Length: 4
	}

	public virtual Byte[] IV
	{
		 get { } //Length: 7
		 set { } //Length: 8
	}

	public virtual Byte[] Key
	{
		 get { } //Length: 7
		 set { } //Length: 8
	}

	public virtual int KeySize
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public virtual CipherMode Mode
	{
		 get { } //Length: 4
		 set { } //Length: 103
	}

	public virtual PaddingMode Padding
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public AesCryptoServiceProvider() { }

	public virtual ICryptoTransform CreateDecryptor() { }

	public virtual ICryptoTransform CreateDecryptor(Byte[] key, Byte[] iv) { }

	public virtual ICryptoTransform CreateEncryptor() { }

	public virtual ICryptoTransform CreateEncryptor(Byte[] key, Byte[] iv) { }

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

