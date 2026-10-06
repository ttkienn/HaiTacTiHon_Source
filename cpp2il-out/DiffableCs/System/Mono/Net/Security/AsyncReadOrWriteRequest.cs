namespace Mono.Net.Security;

internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest
{
	[CompilerGenerated]
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <CurrentSize>k__BackingField; //Field offset: 0x40

	protected int CurrentSize
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected BufferOffsetSize UserBuffer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	[CompilerGenerated]
	protected int get_CurrentSize() { }

	[CompilerGenerated]
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGenerated]
	protected void set_CurrentSize(int value) { }

	public virtual string ToString() { }

}

