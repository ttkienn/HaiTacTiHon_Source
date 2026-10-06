namespace Microsoft.Win32;

public sealed class RegistryKey : MarshalByRefObject, IDisposable
{
	[Flags]
	private enum StateFlags
	{
		Dirty = 1,
		SystemKey = 2,
		WriteAccess = 4,
		PerfData = 8,
	}

	internal static readonly IntPtr HKEY_CLASSES_ROOT; //Field offset: 0x0
	internal static readonly IntPtr HKEY_CURRENT_USER; //Field offset: 0x8
	internal static readonly IntPtr HKEY_LOCAL_MACHINE; //Field offset: 0x10
	internal static readonly IntPtr HKEY_USERS; //Field offset: 0x18
	internal static readonly IntPtr HKEY_PERFORMANCE_DATA; //Field offset: 0x20
	internal static readonly IntPtr HKEY_CURRENT_CONFIG; //Field offset: 0x28
	internal static readonly IntPtr HKEY_DYN_DATA; //Field offset: 0x30
	private static readonly String[] s_hkeyNames; //Field offset: 0x38
	private SafeRegistryHandle _hkey; //Field offset: 0x18
	private string _keyName; //Field offset: 0x20
	private bool _remoteKey; //Field offset: 0x28
	private StateFlags _state; //Field offset: 0x2C
	private RegistryKeyPermissionCheck _checkMode; //Field offset: 0x30
	private RegistryView _regView; //Field offset: 0x34

	private static RegistryKey() { }

	private RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view) { }

	private void ClosePerfDataKey() { }

	public override void Dispose() { }

	private void EnsureNotDisposed() { }

	private static string FixupName(string name) { }

	private static void FixupPath(StringBuilder path) { }

	private static int GetRegistryKeyAccess(bool isWritable) { }

	public String[] GetSubKeyNames() { }

	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable) { }

	public object GetValue(string name, object defaultValue, RegistryValueOptions options) { }

	private String[] InternalGetSubKeyNames() { }

	private String[] InternalGetSubKeyNamesCore(int subkeys) { }

	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity) { }

	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand) { }

	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure) { }

	private int InternalSubKeyCount() { }

	private int InternalSubKeyCountCore() { }

	private bool IsPerfDataKey() { }

	private bool IsSystemKey() { }

	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view) { }

	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view) { }

	public RegistryKey OpenSubKey(string name, bool writable) { }

	public virtual string ToString() { }

	private static void ValidateKeyName(string name) { }

	private static void ValidateKeyView(RegistryView view) { }

	private void Win32Error(int errorCode, string str) { }

}

