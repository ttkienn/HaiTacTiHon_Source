namespace UnityEngine.Purchasing;

internal class ExtensionProvider : IExtensionProvider
{
	private readonly Dictionary<Type, IStoreExtension> m_ExtensionMap; //Field offset: 0x10

	public ExtensionProvider() { }

	public override T GetExtension() { }

	private void RegisterExtensions() { }

}

