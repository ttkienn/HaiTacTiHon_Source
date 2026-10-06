namespace Unity.Services.Wire.Internal;

public interface IChannelTokenProvider
{

	public Task<ChannelToken> GetTokenAsync() { }

}

