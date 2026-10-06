namespace System.Net;

internal class MonoChunkParser
{
	private class Chunk
	{
		public Byte[] Bytes; //Field offset: 0x10
		public int Offset; //Field offset: 0x18

		public Chunk(Byte[] chunk) { }

		public int Read(Byte[] buffer, int offset, int size) { }

	}

	private enum State
	{
		None = 0,
		PartialSize = 1,
		Body = 2,
		BodyFinished = 3,
		Trailer = 4,
	}

	private WebHeaderCollection headers; //Field offset: 0x10
	private int chunkSize; //Field offset: 0x18
	private int chunkRead; //Field offset: 0x1C
	private int totalWritten; //Field offset: 0x20
	private State state; //Field offset: 0x24
	private StringBuilder saved; //Field offset: 0x28
	private bool sawCR; //Field offset: 0x30
	private bool gotit; //Field offset: 0x31
	private int trailerState; //Field offset: 0x34
	private ArrayList chunks; //Field offset: 0x38

	public int ChunkLeft
	{
		 get { } //Length: 7
	}

	public bool DataAvailable
	{
		 get { } //Length: 269
	}

	public bool WantMore
	{
		 get { } //Length: 23
	}

	public MonoChunkParser(WebHeaderCollection headers) { }

	public int get_ChunkLeft() { }

	public bool get_DataAvailable() { }

	public bool get_WantMore() { }

	private State GetChunkSize(Byte[] buffer, ref int offset, int size) { }

	private void InternalWrite(Byte[] buffer, ref int offset, int size) { }

	public int Read(Byte[] buffer, int offset, int size) { }

	private State ReadBody(Byte[] buffer, ref int offset, int size) { }

	private State ReadCRLF(Byte[] buffer, ref int offset, int size) { }

	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	private State ReadTrailer(Byte[] buffer, ref int offset, int size) { }

	private static string RemoveChunkExtension(string input) { }

	private static void ThrowProtocolViolation(string message) { }

	public void Write(Byte[] buffer, int offset, int size) { }

}

