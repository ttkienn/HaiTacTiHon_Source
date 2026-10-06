namespace Mono.Security.Cryptography;

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable
{
	protected SymmetricAlgorithm algo; //Field offset: 0x10
	protected bool encrypt; //Field offset: 0x18
	protected int BlockSizeByte; //Field offset: 0x1C
	protected Byte[] temp; //Field offset: 0x20
	protected Byte[] temp2; //Field offset: 0x28
	private Byte[] workBuff; //Field offset: 0x30
	private Byte[] workout; //Field offset: 0x38
	protected PaddingMode padmode; //Field offset: 0x40
	protected int FeedBackByte; //Field offset: 0x44
	private bool m_disposed; //Field offset: 0x48
	protected bool lastBlock; //Field offset: 0x49
	private RandomNumberGenerator _rng; //Field offset: 0x50

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public override int InputBlockSize
	{
		 get { } //Length: 4
	}

	private bool KeepLastBlock
	{
		private get { } //Length: 23
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 4
	}

	public SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, Byte[] rgbIV) { }

	protected override void CBC(Byte[] input, Byte[] output) { }

	protected override void CFB(Byte[] input, Byte[] output) { }

	private void CheckInput(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected override void CTS(Byte[] input, Byte[] output) { }

	protected override void Dispose(bool disposing) { }

	protected abstract void ECB(Byte[] input, Byte[] output) { }

	protected override Byte[] FinalDecrypt(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected override Byte[] FinalEncrypt(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected virtual void Finalize() { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override int get_InputBlockSize() { }

	private bool get_KeepLastBlock() { }

	public override int get_OutputBlockSize() { }

	private int InternalTransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	protected override void OFB(Byte[] input, Byte[] output) { }

	private void Random(Byte[] buffer, int start, int length) { }

	private override void System.IDisposable.Dispose() { }

	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	protected override void Transform(Byte[] input, Byte[] output) { }

	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

