namespace Unity.Services.Core.Device.Internal;

public interface IInstallationId : IServiceComponent
{

	public string GetOrCreateIdentifier() { }

}

