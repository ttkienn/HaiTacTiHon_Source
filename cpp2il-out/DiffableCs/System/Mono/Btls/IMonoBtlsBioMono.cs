namespace Mono.Btls;

internal interface IMonoBtlsBioMono
{

	public void Close() { }

	public void Flush() { }

	public int Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	public bool Write(Byte[] buffer, int offset, int size) { }

}

