namespace Unity.IO.Archive;

[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
[RequiredByNativeCode]
public struct ArchiveFileInfo
{
	public string Filename; //Field offset: 0x0
	public ulong FileSize; //Field offset: 0x8

}

