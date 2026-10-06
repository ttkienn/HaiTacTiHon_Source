namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable
{
	private static readonly Byte[] s_Sbox; //Field offset: 0x0
	private static readonly Int32[] s_Rcon; //Field offset: 0x8
	private static readonly Int32[] s_T; //Field offset: 0x10
	private static readonly Int32[] s_TF; //Field offset: 0x18
	private static readonly Int32[] s_iT; //Field offset: 0x20
	private static readonly Int32[] s_iTF; //Field offset: 0x28
	private CipherMode m_cipherMode; //Field offset: 0x10
	private PaddingMode m_paddingValue; //Field offset: 0x14
	private RijndaelManagedTransformMode m_transformMode; //Field offset: 0x18
	private int m_blockSizeBits; //Field offset: 0x1C
	private int m_blockSizeBytes; //Field offset: 0x20
	private int m_inputBlockSize; //Field offset: 0x24
	private int m_outputBlockSize; //Field offset: 0x28
	private Int32[] m_encryptKeyExpansion; //Field offset: 0x30
	private Int32[] m_decryptKeyExpansion; //Field offset: 0x38
	private int m_Nr; //Field offset: 0x40
	private int m_Nb; //Field offset: 0x44
	private int m_Nk; //Field offset: 0x48
	private Int32[] m_encryptindex; //Field offset: 0x50
	private Int32[] m_decryptindex; //Field offset: 0x58
	private Int32[] m_IV; //Field offset: 0x60
	private Int32[] m_lastBlockBuffer; //Field offset: 0x68
	private Byte[] m_depadBuffer; //Field offset: 0x70
	private Byte[] m_shiftRegister; //Field offset: 0x78

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public override int InputBlockSize
	{
		 get { } //Length: 4
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 4
	}

	private static RijndaelManagedTransform() { }

	internal RijndaelManagedTransform(Byte[] rgbKey, CipherMode mode, Byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	private void Dec(Int32* decryptindex, Int32* decryptKeyExpansion, Int32* iT, Int32* iTF, Int32* work, Int32* temp) { }

	private int DecryptData(Byte[] inputBuffer, int inputOffset, int inputCount, ref Byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	private void Enc(Int32* encryptindex, Int32* encryptKeyExpansion, Int32* T, Int32* TF, Int32* work, Int32* temp) { }

	private int EncryptData(Byte[] inputBuffer, int inputOffset, int inputCount, ref Byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	private void GenerateKeyExpansion(Byte[] rgbKey) { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override int get_InputBlockSize() { }

	public override int get_OutputBlockSize() { }

	private static int MulX(int x) { }

	public void Reset() { }

	private static int rot1(int val) { }

	private static int rot2(int val) { }

	private static int rot3(int val) { }

	private static int SubWord(int a) { }

	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

