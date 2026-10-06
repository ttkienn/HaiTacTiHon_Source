namespace UnityEngine._Scripting.APIUpdating;

internal class APIUpdaterRuntimeHelpers
{

	[RequiredByNativeCode]
	internal static bool GetMovedFromAttributeDataForType(Type sourceType, out string assembly, out string nsp, out string klass) { }

	[RequiredByNativeCode]
	internal static bool GetObsoleteTypeRedirection(Type sourceType, out string assemblyName, out string nsp, out string className) { }

}

