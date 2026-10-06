namespace System.Security.Cryptography;

[ComVisible(True)]
public class SHA256Managed : SHA256
{
	private static readonly UInt32[] _K; //Field offset: 0x0
	private Byte[] _buffer; //Field offset: 0x28
	private long _count; //Field offset: 0x30
	private UInt32[] _stateSHA256; //Field offset: 0x38
	private UInt32[] _W; //Field offset: 0x40

	private Byte[] _EndHash() { }

	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	private static SHA256Managed() { }

	public SHA256Managed() { }

	private static uint Ch(uint x, uint y, uint z) { }

	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

	private void InitializeState() { }

	private static uint Maj(uint x, uint y, uint z) { }

	private static uint RotateRight(uint x, int n) { }

	private static void SHA256Expand(UInt32* x) { }

	private static void SHATransform(UInt32* expandedBuffer, UInt32* state, Byte* block) { }

	private static uint sigma_0(uint x) { }

	private static uint Sigma_0(uint x) { }

	private static uint sigma_1(uint x) { }

	private static uint Sigma_1(uint x) { }

}

