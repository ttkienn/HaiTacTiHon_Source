namespace Unity.Services.Core.Internal;

public interface IInitializablePackageV2 : IInitializablePackage
{

	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	public void Register(CorePackageRegistry registry) { }

}

