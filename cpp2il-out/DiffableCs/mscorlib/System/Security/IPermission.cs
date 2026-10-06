namespace System.Security;

public interface IPermission : ISecurityEncodable
{

	public void Demand() { }

	public bool IsSubsetOf(IPermission target) { }

}

