namespace System.IO;

internal static class MonoIO
{
	public static readonly IntPtr InvalidHandle; //Field offset: 0x0
	private static bool dump_handles; //Field offset: 0x8

	public static char AltDirectorySeparatorChar
	{
		 get { } //Length: 5
	}

	public static IntPtr ConsoleError
	{
		 get { } //Length: 5
	}

	public static IntPtr ConsoleInput
	{
		 get { } //Length: 5
	}

	public static IntPtr ConsoleOutput
	{
		 get { } //Length: 5
	}

	public static char DirectorySeparatorChar
	{
		 get { } //Length: 5
	}

	public static char PathSeparator
	{
		 get { } //Length: 5
	}

	public static char VolumeSeparatorChar
	{
		 get { } //Length: 5
	}

	private static MonoIO() { }

	internal static bool Cancel(SafeHandle safeHandle, out MonoIOError error) { }

	private static bool Cancel_internal(IntPtr handle, out MonoIOError error) { }

	public static bool Close(IntPtr handle, out MonoIOError error) { }

	private static void DumpHandles() { }

	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	public static bool FindCloseFile(IntPtr hnd) { }

	public static char get_AltDirectorySeparatorChar() { }

	public static IntPtr get_ConsoleError() { }

	public static IntPtr get_ConsoleInput() { }

	public static IntPtr get_ConsoleOutput() { }

	public static char get_DirectorySeparatorChar() { }

	public static char get_PathSeparator() { }

	public static char get_VolumeSeparatorChar() { }

	public static string GetCurrentDirectory(out MonoIOError error) { }

	public static Exception GetException(MonoIOError error) { }

	public static Exception GetException(string path, MonoIOError error) { }

	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	private static IntPtr Open(Char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	public static int Read(SafeHandle safeHandle, Byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	private static int Read(IntPtr handle, Byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	public static bool RemapPath(string path, out string newPath) { }

	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	public static int Write(SafeHandle safeHandle, Byte[] src, int src_offset, int count, out MonoIOError error) { }

	private static int Write(IntPtr handle, in Byte[] src, int src_offset, int count, out MonoIOError error) { }

}

