namespace Unity.Services.Vivox.Internal;

public interface IVivoxTokenProviderInternal
{

	public Task<String> GetTokenAsync(string issuer = null, Nullable<TimeSpan> expiration = null, string userUri = null, string action = null, string conferenceUri = null, string fromUserUri = null, string realm = null) { }

}

