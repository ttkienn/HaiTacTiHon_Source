namespace System.Linq.Expressions;

internal enum AnalyzeTypeIsResult
{
	KnownFalse = 0,
	KnownTrue = 1,
	KnownAssignable = 2,
	Unknown = 3,
}

