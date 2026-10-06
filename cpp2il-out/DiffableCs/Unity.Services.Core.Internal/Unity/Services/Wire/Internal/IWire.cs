namespace Unity.Services.Wire.Internal;

[RequireImplementors]
public interface IWire : IServiceComponent
{

	public IChannel CreateChannel(IChannelTokenProvider tokenProvider) { }

}

