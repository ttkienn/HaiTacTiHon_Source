namespace Unity.Services.Authentication.Server.Internal;

[RequireImplementors]
public interface IServerAccessToken : IAccessToken, IServiceComponent, IAccessTokenObserver
{

}

