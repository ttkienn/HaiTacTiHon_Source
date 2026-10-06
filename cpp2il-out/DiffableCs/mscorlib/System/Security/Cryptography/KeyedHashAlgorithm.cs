namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class KeyedHashAlgorithm : HashAlgorithm
{
	protected Byte[] KeyValue; //Field offset: 0x28

	public override Byte[] Key
	{
		 get { } //Length: 119
		 set { } //Length: 281
	}

	protected KeyedHashAlgorithm() { }

	protected virtual void Dispose(bool disposing) { }

	public override Byte[] get_Key() { }

	public override void set_Key(Byte[] value) { }

}

