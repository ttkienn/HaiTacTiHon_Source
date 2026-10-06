namespace System.Net;

internal enum WebExceptionInternalStatus
{
	RequestFatal = 0,
	ServicePointFatal = 1,
	Recoverable = 2,
	Isolated = 3,
}

