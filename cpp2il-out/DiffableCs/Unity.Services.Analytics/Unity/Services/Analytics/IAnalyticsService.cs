namespace Unity.Services.Analytics;

public interface IAnalyticsService
{

	public string PrivacyUrl
	{
		 get { } //Length: 0
	}

	public string SessionID
	{
		 get { } //Length: 0
	}

	public long ConvertCurrencyToMinorUnits(string currencyCode, double value) { }

	public void Flush() { }

	public string get_PrivacyUrl() { }

	public string get_SessionID() { }

	public string GetAnalyticsUserID() { }

	public void RecordEvent(Event e) { }

	public void RecordEvent(string eventName) { }

	public void RequestDataDeletion() { }

	public void StartDataCollection() { }

	public void StopDataCollection() { }

}

