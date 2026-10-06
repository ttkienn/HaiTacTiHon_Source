namespace Mono.Security.Cryptography;

internal class KeyPairPersistence
{
	private static bool _userPathExists; //Field offset: 0x0
	private static string _userPath; //Field offset: 0x8
	private static bool _machinePathExists; //Field offset: 0x10
	private static string _machinePath; //Field offset: 0x18
	private static object lockobj; //Field offset: 0x20
	private CspParameters _params; //Field offset: 0x10
	private string _keyvalue; //Field offset: 0x18
	private string _filename; //Field offset: 0x20
	private string _container; //Field offset: 0x28

	private bool CanChange
	{
		private get { } //Length: 9
	}

	private string ContainerName
	{
		private get { } //Length: 336
	}

	public string Filename
	{
		 get { } //Length: 441
	}

	public string KeyValue
	{
		 get { } //Length: 5
		 set { } //Length: 21
	}

	private static string MachinePath
	{
		private get { } //Length: 1356
	}

	private bool UseDefaultKeyContainer
	{
		private get { } //Length: 30
	}

	private bool UseMachineKeyStore
	{
		private get { } //Length: 29
	}

	private static string UserPath
	{
		private get { } //Length: 1352
	}

	internal static bool _CanSecure(Char* root) { }

	internal static bool _IsMachineProtected(Char* path) { }

	internal static bool _IsUserProtected(Char* path) { }

	internal static bool _ProtectMachine(Char* path) { }

	internal static bool _ProtectUser(Char* path) { }

	private static KeyPairPersistence() { }

	public KeyPairPersistence(CspParameters parameters) { }

	public KeyPairPersistence(CspParameters parameters, string keyPair) { }

	private static bool CanSecure(string path) { }

	private CspParameters Copy(CspParameters p) { }

	private void FromXml(string xml) { }

	private bool get_CanChange() { }

	private string get_ContainerName() { }

	public string get_Filename() { }

	public string get_KeyValue() { }

	private static string get_MachinePath() { }

	private bool get_UseDefaultKeyContainer() { }

	private bool get_UseMachineKeyStore() { }

	private static string get_UserPath() { }

	private static bool IsMachineProtected(string path) { }

	private static bool IsUserProtected(string path) { }

	public bool Load() { }

	private static bool ProtectMachine(string path) { }

	private static bool ProtectUser(string path) { }

	public void Remove() { }

	public void Save() { }

	public void set_KeyValue(string value) { }

	private string ToXml() { }

}

