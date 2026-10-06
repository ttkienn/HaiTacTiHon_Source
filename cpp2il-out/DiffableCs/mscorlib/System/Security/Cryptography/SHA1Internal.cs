namespace System.Security.Cryptography;

internal class SHA1Internal
{
	private UInt32[] _H; //Field offset: 0x10
	private ulong count; //Field offset: 0x18
	private Byte[] _ProcessingBuffer; //Field offset: 0x20
	private int _ProcessingBufferCount; //Field offset: 0x28
	private UInt32[] buff; //Field offset: 0x30

	public SHA1Internal() { }

	internal void AddLength(ulong length, Byte[] buffer, int position) { }

	private static void FillBuff(UInt32[] buff) { }

	public void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	public Byte[] HashFinal() { }

	private static void InitialiseBuff(UInt32[] buff, Byte[] input, uint inputOffset) { }

	public void Initialize() { }

	private void ProcessBlock(Byte[] inputBuffer, uint inputOffset) { }

	private void ProcessFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

