namespace UnityEngine.Purchasing.Security;

public interface IPurchaseReceipt
{

	public string productID
	{
		 get { } //Length: 0
	}

	public DateTime purchaseDate
	{
		 get { } //Length: 0
	}

	public string transactionID
	{
		 get { } //Length: 0
	}

	public string get_productID() { }

	public DateTime get_purchaseDate() { }

	public string get_transactionID() { }

}

