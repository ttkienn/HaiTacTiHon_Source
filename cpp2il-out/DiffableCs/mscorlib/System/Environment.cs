namespace System;

[ComVisible(True)]
public static class Environment
{
	[ComVisible(True)]
	internal enum SpecialFolder
	{
		MyDocuments = 5,
		Desktop = 0,
		MyComputer = 17,
		Programs = 2,
		Personal = 5,
		Favorites = 6,
		Startup = 7,
		Recent = 8,
		SendTo = 9,
		StartMenu = 11,
		MyMusic = 13,
		DesktopDirectory = 16,
		Templates = 21,
		ApplicationData = 26,
		LocalApplicationData = 28,
		InternetCache = 32,
		Cookies = 33,
		History = 34,
		CommonApplicationData = 35,
		System = 37,
		ProgramFiles = 38,
		MyPictures = 39,
		CommonProgramFiles = 43,
		MyVideos = 14,
		NetworkShortcuts = 19,
		Fonts = 20,
		CommonStartMenu = 22,
		CommonPrograms = 23,
		CommonStartup = 24,
		CommonDesktopDirectory = 25,
		PrinterShortcuts = 27,
		Windows = 36,
		UserProfile = 40,
		SystemX86 = 41,
		ProgramFilesX86 = 42,
		CommonProgramFilesX86 = 44,
		CommonTemplates = 45,
		CommonDocuments = 46,
		CommonAdminTools = 47,
		AdminTools = 48,
		CommonMusic = 53,
		CommonPictures = 54,
		CommonVideos = 55,
		Resources = 56,
		LocalizedResources = 57,
		CommonOemLinks = 58,
		CDBurning = 59,
	}

	internal enum SpecialFolderOption
	{
		None = 0,
		DoNotVerify = 16384,
		Create = 32768,
	}

	private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789"; //Field offset: 0x0
	private static string nl; //Field offset: 0x0
	private static OperatingSystem os; //Field offset: 0x8

	public static string CurrentDirectory
	{
		 get { } //Length: 7
	}

	public static int CurrentManagedThreadId
	{
		 get { } //Length: 35
	}

	public static bool HasShutdownStarted
	{
		 get { } //Length: 5
	}

	internal static bool IsRunningOnWindows
	{
		internal get { } //Length: 20
	}

	internal static bool IsUnix
	{
		internal get { } //Length: 39
	}

	public static string MachineName
	{
		 get { } //Length: 5
	}

	public static string NewLine
	{
		 get { } //Length: 118
	}

	public static OperatingSystem OSVersion
	{
		 get { } //Length: 673
	}

	internal static PlatformID Platform
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public static int ProcessorCount
	{
		 get { } //Length: 5
	}

	public static string StackTrace
	{
		 get { } //Length: 103
	}

	public static string SystemDirectory
	{
		 get { } //Length: 598
	}

	public static int TickCount
	{
		 get { } //Length: 5
	}

	public static string UserDomainName
	{
		 get { } //Length: 5
	}

	public static string UserName
	{
		 get { } //Length: 5
	}

	internal static Version CreateVersionFromString(string info) { }

	public static void Exit(int exitCode) { }

	public static string ExpandEnvironmentVariables(string name) { }

	internal static void FailFast(string message, Exception exception, string errorSource) { }

	public static void FailFast(string message, Exception exception) { }

	public static string get_CurrentDirectory() { }

	public static int get_CurrentManagedThreadId() { }

	public static bool get_HasShutdownStarted() { }

	internal static bool get_IsRunningOnWindows() { }

	internal static bool get_IsUnix() { }

	public static string get_MachineName() { }

	public static string get_NewLine() { }

	public static OperatingSystem get_OSVersion() { }

	[CompilerGenerated]
	internal static PlatformID get_Platform() { }

	public static int get_ProcessorCount() { }

	public static string get_StackTrace() { }

	public static string get_SystemDirectory() { }

	public static int get_TickCount() { }

	public static string get_UserDomainName() { }

	public static string get_UserName() { }

	public static string GetEnvironmentVariable(string variable) { }

	private static String[] GetEnvironmentVariableNames() { }

	private static Hashtable GetEnvironmentVariablesNoCase() { }

	public static string GetFolderPath(SpecialFolder folder) { }

	public static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option) { }

	internal static string GetMachineConfigPath() { }

	private static string GetNewLine() { }

	internal static string GetOSVersionString() { }

	internal static int GetPageSize() { }

	internal static string GetResourceString(string key) { }

	internal static string GetResourceString(string key, Object[] values) { }

	internal static string GetResourceStringEncodingName(int codePage) { }

	internal static string GetStackTrace(Exception e, bool needFileInfo) { }

	private static string GetWindowsFolderPath(int folder) { }

	internal static string internalGetEnvironmentVariable(string variable) { }

	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	internal static string internalGetHome() { }

	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	internal static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option) { }

}

