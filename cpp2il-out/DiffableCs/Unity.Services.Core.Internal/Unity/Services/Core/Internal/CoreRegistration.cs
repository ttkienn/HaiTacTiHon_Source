namespace Unity.Services.Core.Internal;

[IsReadOnly]
public struct CoreRegistration
{
	private readonly IPackageRegistry m_Registry; //Field offset: 0x0
	private readonly int m_PackageHash; //Field offset: 0x8

	internal CoreRegistration(IPackageRegistry registry, int packageHash) { }

	public CoreRegistration DependsOn() { }

	public CoreRegistration OptionallyDependsOn() { }

	public CoreRegistration ProvidesComponent() { }

}

