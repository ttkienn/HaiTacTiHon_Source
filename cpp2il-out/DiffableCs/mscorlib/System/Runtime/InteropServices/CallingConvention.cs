namespace System.Runtime.InteropServices;

[ComVisible(True)]
public enum CallingConvention
{
	Winapi = 1,
	Cdecl = 2,
	StdCall = 3,
	ThisCall = 4,
	FastCall = 5,
}

