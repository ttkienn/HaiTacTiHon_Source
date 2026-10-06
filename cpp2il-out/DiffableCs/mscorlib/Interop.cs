//Type is in global namespace

internal static class Interop
{
	public class Advapi32
	{

		internal static int RegCloseKey(IntPtr hKey) { }

		internal static int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, Char[] lpName, ref int lpcbName, Int32[] lpReserved, out StringBuilder lpClass, Int32[] lpcbClass, Int64[] lpftLastWriteTime) { }

		internal static int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult) { }

		internal static int RegQueryInfoKey(SafeRegistryHandle hKey, out StringBuilder lpClass, Int32[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, Int32[] lpcbMaxSubKeyLen, Int32[] lpcbMaxClassLen, ref int lpcValues, Int32[] lpcbMaxValueNameLen, Int32[] lpcbMaxValueLen, Int32[] lpcbSecurityDescriptor, Int32[] lpftLastWriteTime) { }

		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, out Byte[] lpData, ref int lpcbData) { }

		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, ref int lpData, ref int lpcbData) { }

		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, ref long lpData, ref int lpcbData) { }

		internal static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Int32[] lpReserved, ref int lpType, out Char[] lpData, ref int lpcbData) { }

	}

	public class BCrypt
	{
		public enum NTSTATUS
		{
			STATUS_SUCCESS = 0,
			STATUS_NOT_FOUND = 3221226021,
			STATUS_INVALID_PARAMETER = 3221225485,
			STATUS_NO_MEMORY = 3221225495,
		}


		internal static NTSTATUS BCryptGenRandom(IntPtr hAlgorithm, Byte* pbBuffer, int cbBuffer, int dwFlags) { }

	}

	public enum BOOL
	{
		FALSE = 0,
		TRUE = 1,
	}

	public enum BOOLEAN
	{
		FALSE = 0,
		TRUE = 1,
	}

	public static class Kernel32
	{
		public enum FILE_INFO_BY_HANDLE_CLASS
		{
			FileBasicInfo = 0,
			FileStandardInfo = 1,
			FileNameInfo = 2,
			FileRenameInfo = 3,
			FileDispositionInfo = 4,
			FileAllocationInfo = 5,
			FileEndOfFileInfo = 6,
			FileStreamInfo = 7,
			FileCompressionInfo = 8,
			FileAttributeTagInfo = 9,
			FileIdBothDirectoryInfo = 10,
			FileIdBothDirectoryRestartInfo = 11,
			FileIoPriorityHintInfo = 12,
			FileRemoteProtocolInfo = 13,
			FileFullDirectoryInfo = 14,
			FileFullDirectoryRestartInfo = 15,
		}

		public struct FILE_TIME
		{
			internal uint dwLowDateTime; //Field offset: 0x0
			internal uint dwHighDateTime; //Field offset: 0x4

		}

		public enum FINDEX_INFO_LEVELS
		{
			FindExInfoStandard = 0,
			FindExInfoBasic = 1,
			FindExInfoMaxInfoLevel = 2,
		}

		public enum FINDEX_SEARCH_OPS
		{
			FindExSearchNameMatch = 0,
			FindExSearchLimitToDirectories = 1,
			FindExSearchLimitToDevices = 2,
			FindExSearchMaxSearchOp = 3,
		}

		public enum GET_FILEEX_INFO_LEVELS
		{
			GetFileExInfoStandard = 0,
			GetFileExMaxInfoLevel = 1,
		}

		public struct REG_TZI_FORMAT
		{
			internal int Bias; //Field offset: 0x0
			internal int StandardBias; //Field offset: 0x4
			internal int DaylightBias; //Field offset: 0x8
			internal SYSTEMTIME StandardDate; //Field offset: 0xC
			internal SYSTEMTIME DaylightDate; //Field offset: 0x1C

			internal REG_TZI_FORMAT(in TIME_ZONE_INFORMATION tzi) { }

		}

		public struct SECURITY_ATTRIBUTES
		{
			internal uint nLength; //Field offset: 0x0
			internal IntPtr lpSecurityDescriptor; //Field offset: 0x8
			internal BOOL bInheritHandle; //Field offset: 0x10

		}

		public struct SYSTEMTIME
		{
			internal ushort Year; //Field offset: 0x0
			internal ushort Month; //Field offset: 0x2
			internal ushort DayOfWeek; //Field offset: 0x4
			internal ushort Day; //Field offset: 0x6
			internal ushort Hour; //Field offset: 0x8
			internal ushort Minute; //Field offset: 0xA
			internal ushort Second; //Field offset: 0xC
			internal ushort Milliseconds; //Field offset: 0xE

			internal bool Equals(in SYSTEMTIME other) { }

		}

		public struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <DaylightName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <StandardName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <TimeZoneKeyName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			internal int Bias; //Field offset: 0x0
			[FixedBuffer(typeof(char, 32)]
			internal <StandardName>e__FixedBuffer StandardName; //Field offset: 0x4
			internal SYSTEMTIME StandardDate; //Field offset: 0x44
			internal int StandardBias; //Field offset: 0x54
			[FixedBuffer(typeof(char, 32)]
			internal <DaylightName>e__FixedBuffer DaylightName; //Field offset: 0x58
			internal SYSTEMTIME DaylightDate; //Field offset: 0x98
			internal int DaylightBias; //Field offset: 0xA8
			[FixedBuffer(typeof(char, 128)]
			internal <TimeZoneKeyName>e__FixedBuffer TimeZoneKeyName; //Field offset: 0xAC
			internal byte DynamicDaylightTimeDisabled; //Field offset: 0x1AC

			internal string GetTimeZoneKeyName() { }

		}

		public struct TIME_ZONE_INFORMATION
		{
			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <DaylightName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <StandardName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			internal int Bias; //Field offset: 0x0
			[FixedBuffer(typeof(char, 32)]
			internal <StandardName>e__FixedBuffer StandardName; //Field offset: 0x4
			internal SYSTEMTIME StandardDate; //Field offset: 0x44
			internal int StandardBias; //Field offset: 0x54
			[FixedBuffer(typeof(char, 32)]
			internal <DaylightName>e__FixedBuffer DaylightName; //Field offset: 0x58
			internal SYSTEMTIME DaylightDate; //Field offset: 0x98
			internal int DaylightBias; //Field offset: 0xA8

			internal TIME_ZONE_INFORMATION(in TIME_DYNAMIC_ZONE_INFORMATION dtzi) { }

			internal string GetDaylightName() { }

			internal string GetStandardName() { }

		}

		public struct WIN32_FILE_ATTRIBUTE_DATA
		{
			internal int dwFileAttributes; //Field offset: 0x0
			internal FILE_TIME ftCreationTime; //Field offset: 0x4
			internal FILE_TIME ftLastAccessTime; //Field offset: 0xC
			internal FILE_TIME ftLastWriteTime; //Field offset: 0x14
			internal uint nFileSizeHigh; //Field offset: 0x1C
			internal uint nFileSizeLow; //Field offset: 0x20

			internal void PopulateFrom(ref WIN32_FIND_DATA findData) { }

		}

		public struct WIN32_FIND_DATA
		{
			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <_cAlternateFileName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			[CompilerGenerated]
			[UnsafeValueType]
			internal struct <_cFileName>e__FixedBuffer
			{
				public char FixedElementField; //Field offset: 0x0

			}

			internal uint dwFileAttributes; //Field offset: 0x0
			internal FILE_TIME ftCreationTime; //Field offset: 0x4
			internal FILE_TIME ftLastAccessTime; //Field offset: 0xC
			internal FILE_TIME ftLastWriteTime; //Field offset: 0x14
			internal uint nFileSizeHigh; //Field offset: 0x1C
			internal uint nFileSizeLow; //Field offset: 0x20
			internal uint dwReserved0; //Field offset: 0x24
			internal uint dwReserved1; //Field offset: 0x28
			[FixedBuffer(typeof(char, 260)]
			private <_cFileName>e__FixedBuffer _cFileName; //Field offset: 0x2C
			[FixedBuffer(typeof(char, 14)]
			private <_cAlternateFileName>e__FixedBuffer _cAlternateFileName; //Field offset: 0x234

			internal ReadOnlySpan<Char> cFileName
			{
				internal get { } //Length: 545
			}

			internal ReadOnlySpan<Char> get_cFileName() { }

			internal void SetFileName(string fileName) { }

		}


		internal static bool CloseHandle(IntPtr handle) { }

		internal static bool CreateDirectory(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) { }

		private static bool CreateDirectoryPrivate(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes) { }

		internal static IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes) { }

		private static IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile) { }

		internal static bool DeleteFile(string path) { }

		private static bool DeleteFilePrivate(string path) { }

		internal static bool DeleteVolumeMountPoint(string mountPoint) { }

		internal static bool DeleteVolumeMountPointPrivate(string mountPoint) { }

		internal static SafeFindHandle FindFirstFile(string fileName, ref WIN32_FIND_DATA data) { }

		private static SafeFindHandle FindFirstFileExPrivate(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, ref WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags) { }

		internal static bool FindNextFile(SafeFindHandle hndFindFile, ref WIN32_FIND_DATA lpFindFileData) { }

		private static int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, Char* lpBuffer, int nSize, IntPtr[] arguments) { }

		internal static bool FreeLibrary(IntPtr hModule) { }

		internal static uint GetDynamicTimeZoneInformation(out TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation) { }

		internal static bool GetFileAttributesEx(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

		private static bool GetFileAttributesExPrivate(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation) { }

		public static bool GetFileInformationByHandleEx(IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, IntPtr lpFileInformation, uint dwBufferSize) { }

		internal static bool GetFileMUIPath(uint flags, string filePath, out StringBuilder language, ref int languageLength, out StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator) { }

		internal static string GetMessage(int errorCode) { }

		internal static string GetMessage(IntPtr moduleHandle, int errorCode) { }

		internal static uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

		internal static SafeLibraryHandle LoadLibraryEx(string libFilename, IntPtr reserved, int flags) { }

		internal static bool RemoveDirectory(string path) { }

		private static bool RemoveDirectoryPrivate(string path) { }

		internal static bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode) { }

		private static bool TryGetErrorMessage(IntPtr moduleHandle, int errorCode, Span<Char> buffer, out string errorMsg) { }

	}

	public struct LongFileTime
	{
		internal long TicksSince1601; //Field offset: 0x0

	}

	public class NtDll
	{
		internal enum CreateDisposition
		{
			FILE_SUPERSEDE = 0,
			FILE_OPEN = 1,
			FILE_CREATE = 2,
			FILE_OPEN_IF = 3,
			FILE_OVERWRITE = 4,
			FILE_OVERWRITE_IF = 5,
		}

		internal enum CreateOptions
		{
			FILE_DIRECTORY_FILE = 1,
			FILE_WRITE_THROUGH = 2,
			FILE_SEQUENTIAL_ONLY = 4,
			FILE_NO_INTERMEDIATE_BUFFERING = 8,
			FILE_SYNCHRONOUS_IO_ALERT = 16,
			FILE_SYNCHRONOUS_IO_NONALERT = 32,
			FILE_NON_DIRECTORY_FILE = 64,
			FILE_CREATE_TREE_CONNECTION = 128,
			FILE_COMPLETE_IF_OPLOCKED = 256,
			FILE_NO_EA_KNOWLEDGE = 512,
			FILE_RANDOM_ACCESS = 2048,
			FILE_DELETE_ON_CLOSE = 4096,
			FILE_OPEN_BY_FILE_ID = 8192,
			FILE_OPEN_FOR_BACKUP_INTENT = 16384,
			FILE_NO_COMPRESSION = 32768,
			FILE_OPEN_REQUIRING_OPLOCK = 65536,
			FILE_DISALLOW_EXCLUSIVE = 131072,
			FILE_SESSION_AWARE = 262144,
			FILE_RESERVE_OPFILTER = 1048576,
			FILE_OPEN_REPARSE_POINT = 2097152,
			FILE_OPEN_NO_RECALL = 4194304,
		}

		[Flags]
		internal enum DesiredAccess
		{
			FILE_READ_DATA = 1,
			FILE_LIST_DIRECTORY = 1,
			FILE_WRITE_DATA = 2,
			FILE_ADD_FILE = 2,
			FILE_APPEND_DATA = 4,
			FILE_ADD_SUBDIRECTORY = 4,
			FILE_CREATE_PIPE_INSTANCE = 4,
			FILE_READ_EA = 8,
			FILE_WRITE_EA = 16,
			FILE_EXECUTE = 32,
			FILE_TRAVERSE = 32,
			FILE_DELETE_CHILD = 64,
			FILE_READ_ATTRIBUTES = 128,
			FILE_WRITE_ATTRIBUTES = 256,
			FILE_ALL_ACCESS = 983551,
			DELETE = 65536,
			READ_CONTROL = 131072,
			WRITE_DAC = 262144,
			WRITE_OWNER = 524288,
			SYNCHRONIZE = 1048576,
			STANDARD_RIGHTS_READ = 131072,
			STANDARD_RIGHTS_WRITE = 131072,
			STANDARD_RIGHTS_EXECUTE = 131072,
			FILE_GENERIC_READ = 2147483648,
			FILE_GENERIC_WRITE = 1073741824,
			FILE_GENERIC_EXECUTE = 536870912,
		}

		internal struct FILE_FULL_DIR_INFORMATION
		{
			public uint NextEntryOffset; //Field offset: 0x0
			public uint FileIndex; //Field offset: 0x4
			public LongFileTime CreationTime; //Field offset: 0x8
			public LongFileTime LastAccessTime; //Field offset: 0x10
			public LongFileTime LastWriteTime; //Field offset: 0x18
			public LongFileTime ChangeTime; //Field offset: 0x20
			public long EndOfFile; //Field offset: 0x28
			public long AllocationSize; //Field offset: 0x30
			public FileAttributes FileAttributes; //Field offset: 0x38
			public uint FileNameLength; //Field offset: 0x3C
			public uint EaSize; //Field offset: 0x40
			private char _fileName; //Field offset: 0x44

			public ReadOnlySpan<Char> FileName
			{
				 get { } //Length: 103
			}

			public ReadOnlySpan<Char> get_FileName() { }

			public static FILE_FULL_DIR_INFORMATION* GetNextInfo(FILE_FULL_DIR_INFORMATION* info) { }

		}

		internal enum FILE_INFORMATION_CLASS
		{
			FileDirectoryInformation = 1,
			FileFullDirectoryInformation = 2,
			FileBothDirectoryInformation = 3,
			FileBasicInformation = 4,
			FileStandardInformation = 5,
			FileInternalInformation = 6,
			FileEaInformation = 7,
			FileAccessInformation = 8,
			FileNameInformation = 9,
			FileRenameInformation = 10,
			FileLinkInformation = 11,
			FileNamesInformation = 12,
			FileDispositionInformation = 13,
			FilePositionInformation = 14,
			FileFullEaInformation = 15,
			FileModeInformation = 16,
			FileAlignmentInformation = 17,
			FileAllInformation = 18,
			FileAllocationInformation = 19,
			FileEndOfFileInformation = 20,
			FileAlternateNameInformation = 21,
			FileStreamInformation = 22,
			FilePipeInformation = 23,
			FilePipeLocalInformation = 24,
			FilePipeRemoteInformation = 25,
			FileMailslotQueryInformation = 26,
			FileMailslotSetInformation = 27,
			FileCompressionInformation = 28,
			FileObjectIdInformation = 29,
			FileCompletionInformation = 30,
			FileMoveClusterInformation = 31,
			FileQuotaInformation = 32,
			FileReparsePointInformation = 33,
			FileNetworkOpenInformation = 34,
			FileAttributeTagInformation = 35,
			FileTrackingInformation = 36,
			FileIdBothDirectoryInformation = 37,
			FileIdFullDirectoryInformation = 38,
			FileValidDataLengthInformation = 39,
			FileShortNameInformation = 40,
			FileIoCompletionNotificationInformation = 41,
			FileIoStatusBlockRangeInformation = 42,
			FileIoPriorityHintInformation = 43,
			FileSfioReserveInformation = 44,
			FileSfioVolumeInformation = 45,
			FileHardLinkInformation = 46,
			FileProcessIdsUsingFileInformation = 47,
			FileNormalizedNameInformation = 48,
			FileNetworkPhysicalNameInformation = 49,
			FileIdGlobalTxDirectoryInformation = 50,
			FileIsRemoteDeviceInformation = 51,
			FileUnusedInformation = 52,
			FileNumaNodeInformation = 53,
			FileStandardLinkInformation = 54,
			FileRemoteProtocolInformation = 55,
			FileRenameInformationBypassAccessCheck = 56,
			FileLinkInformationBypassAccessCheck = 57,
			FileVolumeNameInformation = 58,
			FileIdInformation = 59,
			FileIdExtdDirectoryInformation = 60,
			FileReplaceCompletionInformation = 61,
			FileHardLinkFullIdInformation = 62,
			FileIdExtdBothDirectoryInformation = 63,
			FileDispositionInformationEx = 64,
			FileRenameInformationEx = 65,
			FileRenameInformationExBypassAccessCheck = 66,
			FileDesiredStorageClassInformation = 67,
			FileStatInformation = 68,
		}

		internal struct IO_STATUS_BLOCK
		{
			internal struct IO_STATUS
			{
				public uint Status; //Field offset: 0x0
				public IntPtr Pointer; //Field offset: 0x0

			}

			public IO_STATUS Status; //Field offset: 0x0
			public IntPtr Information; //Field offset: 0x8

		}

		internal struct OBJECT_ATTRIBUTES
		{
			public uint Length; //Field offset: 0x0
			public IntPtr RootDirectory; //Field offset: 0x8
			public UNICODE_STRING* ObjectName; //Field offset: 0x10
			public ObjectAttributes Attributes; //Field offset: 0x18
			public Void* SecurityDescriptor; //Field offset: 0x20
			public Void* SecurityQualityOfService; //Field offset: 0x28

			public OBJECT_ATTRIBUTES(UNICODE_STRING* objectName, ObjectAttributes attributes, IntPtr rootDirectory) { }

		}

		[Flags]
		internal enum ObjectAttributes
		{
			OBJ_INHERIT = 2,
			OBJ_PERMANENT = 16,
			OBJ_EXCLUSIVE = 32,
			OBJ_CASE_INSENSITIVE = 64,
			OBJ_OPENIF = 128,
			OBJ_OPENLINK = 256,
		}


		internal static ValueTuple<Int32, IntPtr> CreateFile(ReadOnlySpan<Char> path, IntPtr rootDirectory, CreateDisposition createDisposition, DesiredAccess desiredAccess = 2148532224, FileShare shareAccess = 7, FileAttributes fileAttributes = 0, CreateOptions createOptions = 32, ObjectAttributes objectAttributes = 64) { }

		private static int NtCreateFile(out IntPtr FileHandle, DesiredAccess DesiredAccess, ref OBJECT_ATTRIBUTES ObjectAttributes, out IO_STATUS_BLOCK IoStatusBlock, Int64* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, CreateDisposition CreateDisposition, CreateOptions CreateOptions, Void* EaBuffer, uint EaLength) { }

		public static int NtQueryDirectoryFile(IntPtr FileHandle, IntPtr Event, IntPtr ApcRoutine, IntPtr ApcContext, out IO_STATUS_BLOCK IoStatusBlock, IntPtr FileInformation, uint Length, FILE_INFORMATION_CLASS FileInformationClass, BOOLEAN ReturnSingleEntry, UNICODE_STRING* FileName, BOOLEAN RestartScan) { }

		public static uint RtlNtStatusToDosError(int Status) { }

	}

	public struct UNICODE_STRING
	{
		internal ushort Length; //Field offset: 0x0
		internal ushort MaximumLength; //Field offset: 0x2
		internal IntPtr Buffer; //Field offset: 0x8

	}

	public class User32
	{

		internal static int LoadString(SafeLibraryHandle handle, int id, out StringBuilder buffer, int bufferLength) { }

	}


	internal static void GetRandomBytes(Byte* buffer, int length) { }

}

