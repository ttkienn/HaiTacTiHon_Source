namespace System.Resources;

internal class ManifestBasedResourceGroveler : IResourceGroveler
{
	private ResourceManagerMediator _mediator; //Field offset: 0x10

	public ManifestBasedResourceGroveler(ResourceManagerMediator mediator) { }

	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }

}

