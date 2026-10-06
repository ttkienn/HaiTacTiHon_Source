namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class MD5CryptoServiceProvider : MD5
{
	private static readonly UInt32[] K; //Field offset: 0x0
	private UInt32[] _H; //Field offset: 0x28
	private UInt32[] buff; //Field offset: 0x30
	private ulong count; //Field offset: 0x38
	private Byte[] _ProcessingBuffer; //Field offset: 0x40
	private int _ProcessingBufferCount; //Field offset: 0x48

	private static MD5CryptoServiceProvider() { }

	public MD5CryptoServiceProvider() { }

	internal void AddLength(ulong length, Byte[] buffer, int position) { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

	private void ProcessBlock(Byte[] inputBuffer, int inputOffset) { }

	private void ProcessFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

