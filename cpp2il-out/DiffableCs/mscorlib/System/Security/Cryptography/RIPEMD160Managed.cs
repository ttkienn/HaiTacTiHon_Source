namespace System.Security.Cryptography;

[ComVisible(True)]
public class RIPEMD160Managed : RIPEMD160
{
	private Byte[] _buffer; //Field offset: 0x28
	private long _count; //Field offset: 0x30
	private UInt32[] _stateMD160; //Field offset: 0x38
	private UInt32[] _blockDWords; //Field offset: 0x40

	private Byte[] _EndHash() { }

	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	public RIPEMD160Managed() { }

	private static uint F(uint x, uint y, uint z) { }

	private static uint G(uint x, uint y, uint z) { }

	private static uint H(uint x, uint y, uint z) { }

	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	private static uint I(uint x, uint y, uint z) { }

	public virtual void Initialize() { }

	private void InitializeState() { }

	private static uint J(uint x, uint y, uint z) { }

	private static void MDTransform(UInt32* blockDWords, UInt32* state, Byte* block) { }

}

