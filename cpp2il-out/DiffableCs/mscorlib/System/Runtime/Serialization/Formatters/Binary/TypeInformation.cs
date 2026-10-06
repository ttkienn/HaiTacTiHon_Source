namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class TypeInformation
{
	private string fullTypeName; //Field offset: 0x10
	private string assemblyString; //Field offset: 0x18
	private bool hasTypeForwardedFrom; //Field offset: 0x20

	internal string AssemblyString
	{
		internal get { } //Length: 5
	}

	internal string FullTypeName
	{
		internal get { } //Length: 5
	}

	internal bool HasTypeForwardedFrom
	{
		internal get { } //Length: 5
	}

	internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

	internal string get_AssemblyString() { }

	internal string get_FullTypeName() { }

	internal bool get_HasTypeForwardedFrom() { }

}

