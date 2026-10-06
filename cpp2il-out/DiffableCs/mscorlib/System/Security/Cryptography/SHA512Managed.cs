namespace System.Security.Cryptography;

[ComVisible(True)]
public class SHA512Managed : SHA512
{
	private static readonly UInt64[] _K; //Field offset: 0x0
	private Byte[] _buffer; //Field offset: 0x28
	private ulong _count; //Field offset: 0x30
	private UInt64[] _stateSHA512; //Field offset: 0x38
	private UInt64[] _W; //Field offset: 0x40

	private Byte[] _EndHash() { }

	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	private static SHA512Managed() { }

	public SHA512Managed() { }

	private static ulong Ch(ulong x, ulong y, ulong z) { }

	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

	private void InitializeState() { }

	private static ulong Maj(ulong x, ulong y, ulong z) { }

	private static ulong RotateRight(ulong x, int n) { }

	private static void SHA512Expand(UInt64* x) { }

	private static void SHATransform(UInt64* expandedBuffer, UInt64* state, Byte* block) { }

	private static ulong sigma_0(ulong x) { }

	private static ulong Sigma_0(ulong x) { }

	private static ulong sigma_1(ulong x) { }

	private static ulong Sigma_1(ulong x) { }

}

