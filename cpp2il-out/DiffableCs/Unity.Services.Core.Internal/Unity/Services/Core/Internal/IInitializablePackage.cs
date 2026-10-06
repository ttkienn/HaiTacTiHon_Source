namespace Unity.Services.Core.Internal;

public interface IInitializablePackage
{

	public Task Initialize(CoreRegistry registry) { }

}

