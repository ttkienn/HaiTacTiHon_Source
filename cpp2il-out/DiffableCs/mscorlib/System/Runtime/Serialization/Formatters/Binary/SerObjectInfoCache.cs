namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerObjectInfoCache
{
	internal string fullTypeName; //Field offset: 0x10
	internal string assemblyString; //Field offset: 0x18
	internal bool hasTypeForwardedFrom; //Field offset: 0x20
	internal MemberInfo[] memberInfos; //Field offset: 0x28
	internal String[] memberNames; //Field offset: 0x30
	internal Type[] memberTypes; //Field offset: 0x38

	internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	internal SerObjectInfoCache(Type type) { }

}

