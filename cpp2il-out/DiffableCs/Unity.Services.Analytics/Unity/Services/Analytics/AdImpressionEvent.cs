namespace Unity.Services.Analytics;

public class AdImpressionEvent : Event
{
	private static readonly String[] k_AdPlacementTypeValues; //Field offset: 0x0
	private static readonly String[] k_AdProviderValues; //Field offset: 0x8
	private static readonly String[] k_AdCompletionStatusValues; //Field offset: 0x10

	public AdCompletionStatus AdCompletionStatus
	{
		 set { } //Length: 206
	}

	public double AdEcpmUsd
	{
		 set { } //Length: 131
	}

	public bool AdHasClicked
	{
		 set { } //Length: 132
	}

	public string AdImpressionId
	{
		 set { } //Length: 131
	}

	public long AdLengthMs
	{
		 set { } //Length: 131
	}

	public string AdMediaType
	{
		 set { } //Length: 131
	}

	public AdProvider AdProvider
	{
		 set { } //Length: 206
	}

	public string AdSdkVersion
	{
		 set { } //Length: 131
	}

	public string AdSource
	{
		 set { } //Length: 131
	}

	public string AdStatusCallback
	{
		 set { } //Length: 131
	}

	public string AdStoreDestinationId
	{
		 set { } //Length: 131
	}

	public long AdTimeCloseButtonShownMs
	{
		 set { } //Length: 131
	}

	public long AdTimeWatchedMs
	{
		 set { } //Length: 131
	}

	public string PlacementId
	{
		 set { } //Length: 131
	}

	public string PlacementName
	{
		 set { } //Length: 131
	}

	public AdPlacementType PlacementType
	{
		 set { } //Length: 205
	}

	private static AdImpressionEvent() { }

	public AdImpressionEvent() { }

	public void set_AdCompletionStatus(AdCompletionStatus value) { }

	public void set_AdEcpmUsd(double value) { }

	public void set_AdHasClicked(bool value) { }

	public void set_AdImpressionId(string value) { }

	public void set_AdLengthMs(long value) { }

	public void set_AdMediaType(string value) { }

	public void set_AdProvider(AdProvider value) { }

	public void set_AdSdkVersion(string value) { }

	public void set_AdSource(string value) { }

	public void set_AdStatusCallback(string value) { }

	public void set_AdStoreDestinationId(string value) { }

	public void set_AdTimeCloseButtonShownMs(long value) { }

	public void set_AdTimeWatchedMs(long value) { }

	public void set_PlacementId(string value) { }

	public void set_PlacementName(string value) { }

	public void set_PlacementType(AdPlacementType value) { }

	public virtual void Validate() { }

}

