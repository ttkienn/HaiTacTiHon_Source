namespace UnityEngine.Purchasing;

public interface IAppleStoreExtendedService : IStoreServiceExtension
{

	public bool canMakePayments
	{
		 get { } //Length: 0
	}

	public void ClearTransactionLog() { }

	public bool get_canMakePayments() { }

	public void SetAppAccountToken(Guid appAccountToken) { }

}

