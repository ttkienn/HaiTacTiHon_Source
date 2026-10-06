namespace System.Security.Cryptography;

[ComVisible(True)]
public class SHA1Managed : SHA1
{
	private Byte[] _buffer; //Field offset: 0x28
	private long _count; //Field offset: 0x30
	private UInt32[] _stateSHA1; //Field offset: 0x38
	private UInt32[] _expandedBuffer; //Field offset: 0x40

	private Byte[] _EndHash() { }

	private void _HashData(Byte[] partIn, int ibStart, int cbSize) { }

	public SHA1Managed() { }

	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

	private void InitializeState() { }

	private static void SHAExpand(UInt32* x) { }

	private static void SHATransform(UInt32* expandedBuffer, UInt32* state, Byte* block) { }

}

