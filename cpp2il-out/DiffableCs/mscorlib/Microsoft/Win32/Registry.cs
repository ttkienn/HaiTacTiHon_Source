namespace Microsoft.Win32;

public static class Registry
{
	public static readonly RegistryKey CurrentUser; //Field offset: 0x0
	public static readonly RegistryKey LocalMachine; //Field offset: 0x8
	public static readonly RegistryKey ClassesRoot; //Field offset: 0x10
	public static readonly RegistryKey Users; //Field offset: 0x18
	public static readonly RegistryKey PerformanceData; //Field offset: 0x20
	public static readonly RegistryKey CurrentConfig; //Field offset: 0x28
	[Obsolete("Use PerformanceData instead")]
	public static readonly RegistryKey DynData; //Field offset: 0x30

	private static Registry() { }

}

