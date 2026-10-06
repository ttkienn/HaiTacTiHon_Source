namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class AsymmetricAlgorithm : IDisposable
{
	protected int KeySizeValue; //Field offset: 0x10
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0x18

	public override int KeySize
	{
		 get { } //Length: 191
		 set { } //Length: 324
	}

	protected AsymmetricAlgorithm() { }

	public void Clear() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override void FromXmlString(string xmlString) { }

	public override int get_KeySize() { }

	public override void set_KeySize(int value) { }

	public override string ToXmlString(bool includePrivateParameters) { }

}

