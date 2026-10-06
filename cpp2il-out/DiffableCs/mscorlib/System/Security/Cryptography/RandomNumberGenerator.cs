namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class RandomNumberGenerator : IDisposable
{

	protected RandomNumberGenerator() { }

	public static RandomNumberGenerator Create() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public abstract void GetBytes(Byte[] data) { }

}

