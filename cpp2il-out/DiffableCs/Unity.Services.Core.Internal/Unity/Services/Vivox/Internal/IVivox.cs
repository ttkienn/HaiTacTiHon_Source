namespace Unity.Services.Vivox.Internal;

[RequireImplementors]
public interface IVivox : IServiceComponent
{

	public void RegisterTokenProvider(IVivoxTokenProviderInternal tokenProvider) { }

}

