namespace UnityEngine.Purchasing.Models;

internal interface IGoogleBillingResult
{

	public string debugMessage
	{
		 get { } //Length: 0
	}

	public GoogleBillingResponseCode responseCode
	{
		 get { } //Length: 0
	}

	public string get_debugMessage() { }

	public GoogleBillingResponseCode get_responseCode() { }

}

