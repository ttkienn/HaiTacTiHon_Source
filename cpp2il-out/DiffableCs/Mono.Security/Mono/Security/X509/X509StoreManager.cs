namespace Mono.Security.X509;

public sealed class X509StoreManager
{
	private static string _userPath; //Field offset: 0x0
	private static string _localMachinePath; //Field offset: 0x8
	private static string _newUserPath; //Field offset: 0x10
	private static string _newLocalMachinePath; //Field offset: 0x18
	private static X509Stores _userStore; //Field offset: 0x20
	private static X509Stores _machineStore; //Field offset: 0x28

	public static X509Stores CurrentUser
	{
		 get { } //Length: 470
	}

	internal static string CurrentUserPath
	{
		internal get { } //Length: 288
	}

	public static X509Stores LocalMachine
	{
		 get { } //Length: 483
	}

	internal static string LocalMachinePath
	{
		internal get { } //Length: 301
	}

	internal static string NewCurrentUserPath
	{
		internal get { } //Length: 301
	}

	internal static string NewLocalMachinePath
	{
		internal get { } //Length: 301
	}

	public static X509CertificateCollection TrustedRootCertificates
	{
		 get { } //Length: 1151
	}

	public static X509Stores get_CurrentUser() { }

	internal static string get_CurrentUserPath() { }

	public static X509Stores get_LocalMachine() { }

	internal static string get_LocalMachinePath() { }

	internal static string get_NewCurrentUserPath() { }

	internal static string get_NewLocalMachinePath() { }

	public static X509CertificateCollection get_TrustedRootCertificates() { }

}

