namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[ComVisible(True)]
public sealed class DllImportAttribute : Attribute
{
	internal string _val; //Field offset: 0x10
	public string EntryPoint; //Field offset: 0x18
	public CharSet CharSet; //Field offset: 0x20
	public bool SetLastError; //Field offset: 0x24
	public bool ExactSpelling; //Field offset: 0x25
	public bool PreserveSig; //Field offset: 0x26
	public CallingConvention CallingConvention; //Field offset: 0x28
	public bool BestFitMapping; //Field offset: 0x2C
	public bool ThrowOnUnmappableChar; //Field offset: 0x2D

	public string Value
	{
		 get { } //Length: 5
	}

	internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	public DllImportAttribute(string dllName) { }

	public string get_Value() { }

	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	internal static bool IsDefined(RuntimeMethodInfo method) { }

}

