namespace System.Runtime.InteropServices;

[ComVisible(True)]
public enum ComInterfaceType
{
	InterfaceIsDual = 0,
	InterfaceIsIUnknown = 1,
	InterfaceIsIDispatch = 2,
	InterfaceIsIInspectable = 3,
}

