namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryAssemblyInfo
{
	internal string assemblyString; //Field offset: 0x10
	private Assembly assembly; //Field offset: 0x18

	internal BinaryAssemblyInfo(string assemblyString) { }

	internal BinaryAssemblyInfo(string assemblyString, Assembly assembly) { }

	internal Assembly GetAssembly() { }

}

