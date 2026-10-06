namespace System.Security;

[ComVisible(True)]
public static class SecurityManager
{

	[Obsolete("The security manager cannot be turned off on MS runtime")]
	public static bool SecurityEnabled
	{
		 get { } //Length: 3
	}

	internal static void EnsureElevatedPermissions() { }

	public static bool get_SecurityEnabled() { }

}

