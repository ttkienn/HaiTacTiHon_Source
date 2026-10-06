namespace System.Net;

internal enum FtpLoginState
{
	NotLoggedIn = 0,
	LoggedIn = 1,
	LoggedInButNeedsRelogin = 2,
	ReloginFailed = 3,
}

