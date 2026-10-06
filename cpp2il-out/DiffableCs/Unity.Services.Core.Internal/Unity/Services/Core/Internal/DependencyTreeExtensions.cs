namespace Unity.Services.Core.Internal;

[Extension]
internal static class DependencyTreeExtensions
{

	private static string GetComponentIdentifier(IServiceComponent component) { }

	private static JObject GetComponentJObject(DependencyTree tree, int componentHash) { }

	private static JObject GetPackageJObject(DependencyTree tree, int packageHash) { }

	[Extension]
	internal static bool IsOptional(DependencyTree tree, int componentTypeHash) { }

	[Extension]
	internal static bool IsProvided(DependencyTree tree, int componentTypeHash) { }

	[Extension]
	internal static string ToJson(DependencyTree tree, ICollection<Int32> order = null) { }

}

