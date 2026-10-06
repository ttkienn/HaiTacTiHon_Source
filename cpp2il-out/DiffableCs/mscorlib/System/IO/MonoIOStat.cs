namespace System.IO;

internal struct MonoIOStat
{
	public FileAttributes fileAttributes; //Field offset: 0x0
	public long Length; //Field offset: 0x8
	public long CreationTime; //Field offset: 0x10
	public long LastAccessTime; //Field offset: 0x18
	public long LastWriteTime; //Field offset: 0x20

}

