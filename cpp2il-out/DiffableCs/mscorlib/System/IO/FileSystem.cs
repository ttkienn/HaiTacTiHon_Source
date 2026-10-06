namespace System.IO;

internal static class FileSystem
{
	private class UnitySafeFindHandle : SafeFindHandle
	{
		private readonly IntPtr m_Handle; //Field offset: 0x20

		public IntPtr Handle
		{
			 get { } //Length: 5
		}

		public virtual bool IsInvalid
		{
			 get { } //Length: 14
		}

		public UnitySafeFindHandle(IntPtr handle) { }

		protected virtual void Dispose(bool disposing) { }

		public IntPtr get_Handle() { }

		public virtual bool get_IsInvalid() { }

	}


	private static bool BrokeredCreateDirectory(string path) { }

	private static bool BrokeredDeleteFile(string path) { }

	private static IntPtr BrokeredFindFirstFile(string searchPath, ref string resultFilePath, ref uint attributes) { }

	private static bool BrokeredFindNextFile(IntPtr handle, ref string resultFilePath, ref uint attributes) { }

	private static bool BrokeredGetFileAttributes(string path, ref WIN32_FILE_ATTRIBUTE_DATA data) { }

	private static IntPtr BrokeredOpenFile(string lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, int dwFlagsAndAttributes) { }

	private static bool BrokeredRemoveDirectory(string path) { }

	private static int BrokeredSafeFindHandleDispose(IntPtr handle) { }

	public static void CreateDirectory(string fullPath) { }

	public static void DeleteFile(string fullPath) { }

	private static bool DirectoryExists(string path, out int lastError) { }

	public static bool DirectoryExists(string fullPath) { }

	public static bool FileExists(string fullPath) { }

	internal static int FillAttributeInfo(string path, ref WIN32_FILE_ATTRIBUTE_DATA data, bool returnErrorOnNotFound) { }

	private static void GetFindData(string fullPath, ref WIN32_FIND_DATA findData) { }

	private static bool IsNameSurrogateReparsePoint(ref WIN32_FIND_DATA data) { }

	public static void RemoveDirectory(string fullPath, bool recursive) { }

	private static void RemoveDirectoryInternal(string fullPath, bool topLevel, bool allowDirectoryNotEmpty = false) { }

	private static void RemoveDirectoryRecursive(string fullPath, ref WIN32_FIND_DATA findData, bool topLevel) { }

	private static string RemoveExtendedPathPrefix(string path) { }

	private static bool UnityCreateDirectory(string name) { }

	internal static IntPtr UnityCreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

	private static bool UnityDeleteFile(string path) { }

	private static SafeFindHandle UnityFindFirstFile(string path, ref WIN32_FIND_DATA findData) { }

	private static bool UnityFindNextFile(SafeFindHandle handle, ref WIN32_FIND_DATA findData) { }

	private static bool UnityGetFileAttributesEx(string path, ref WIN32_FILE_ATTRIBUTE_DATA data) { }

	private static bool UnityRemoveDirectory(string fullPath) { }

}

