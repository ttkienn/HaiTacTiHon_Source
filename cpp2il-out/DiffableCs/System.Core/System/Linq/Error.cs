namespace System.Linq;

internal static class Error
{

	internal static Exception ArgumentNull(string s) { }

	internal static Exception ArgumentOutOfRange(string s) { }

	internal static Exception MoreThanOneElement() { }

	internal static Exception MoreThanOneMatch() { }

	internal static Exception NoElements() { }

	internal static Exception NoMatch() { }

	internal static Exception NotSupported() { }

}

