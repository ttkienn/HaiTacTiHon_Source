namespace System.IO;

[ComVisible(True)]
public static class Path
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"First", "FirstLength", "Second", "SecondLength", "HasSeparator"}])]
		public static SpanAction<Char, ValueTuple`5<IntPtr, Int32, IntPtr, Int32, Boolean>> <>9__59_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"First", "FirstLength", "Second", "SecondLength", "Third", "ThirdLength", "FirstHasSeparator", "ThirdHasSeparator", null}])]
		public static SpanAction<Char, ValueTuple`8<IntPtr, Int32, IntPtr, Int32, IntPtr, Int32, Boolean, ValueTuple`1<Boolean>>> <>9__60_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <JoinInternal>b__59_0(Span<Char> destination, ValueTuple<IntPtr, Int32, IntPtr, Int32, Boolean> state) { }

		internal void <JoinInternal>b__60_0(Span<Char> destination, ValueTuple<IntPtr, Int32, IntPtr, Int32, IntPtr, Int32, Boolean, ValueTuple`1<Boolean>> state) { }

	}

	[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
	public static readonly Char[] InvalidPathChars; //Field offset: 0x0
	public static readonly char AltDirectorySeparatorChar; //Field offset: 0x8
	public static readonly char DirectorySeparatorChar; //Field offset: 0xA
	public static readonly char PathSeparator; //Field offset: 0xC
	internal static readonly string DirectorySeparatorStr; //Field offset: 0x10
	public static readonly char VolumeSeparatorChar; //Field offset: 0x18
	internal static readonly Char[] PathSeparatorChars; //Field offset: 0x20
	private static readonly bool dirEqualsVolume; //Field offset: 0x28
	internal static readonly Char[] trimEndCharsWindows; //Field offset: 0x30
	internal static readonly Char[] trimEndCharsUnix; //Field offset: 0x38

	private static Path() { }

	private static string CanonicalizePath(string path) { }

	public static string ChangeExtension(string path, string extension) { }

	internal static string CleanPath(string s) { }

	public static string Combine(string path1, string path2) { }

	public static string Combine(String[] paths) { }

	public static string Combine(string path1, string path2, string path3) { }

	private static int findExtension(string path) { }

	private static string get_temp_path() { }

	public static ReadOnlySpan<Char> GetDirectoryName(ReadOnlySpan<Char> path) { }

	public static string GetDirectoryName(string path) { }

	public static string GetExtension(string path) { }

	public static ReadOnlySpan<Char> GetFileName(ReadOnlySpan<Char> path) { }

	public static string GetFileName(string path) { }

	public static string GetFileNameWithoutExtension(string path) { }

	public static string GetFullPath(string path) { }

	internal static string GetFullPathInternal(string path) { }

	internal static string GetFullPathName(string path) { }

	private static int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	public static Char[] GetInvalidPathChars() { }

	public static string GetPathRoot(string path) { }

	private static string GetServerAndShare(string path) { }

	public static string GetTempPath() { }

	internal static string InsecureGetFullPath(string path) { }

	internal static bool IsDirectorySeparator(char c) { }

	public static bool IsPathRooted(ReadOnlySpan<Char> path) { }

	public static bool IsPathRooted(string path) { }

	public static string Join(ReadOnlySpan<Char> path1, ReadOnlySpan<Char> path2) { }

	public static string Join(ReadOnlySpan<Char> path1, ReadOnlySpan<Char> path2, ReadOnlySpan<Char> path3) { }

	private static string JoinInternal(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second) { }

	private static string JoinInternal(ReadOnlySpan<Char> first, ReadOnlySpan<Char> second, ReadOnlySpan<Char> third) { }

	private static bool SameRoot(string root, string path) { }

	internal static string WindowsDriveAdjustment(string path) { }

}

