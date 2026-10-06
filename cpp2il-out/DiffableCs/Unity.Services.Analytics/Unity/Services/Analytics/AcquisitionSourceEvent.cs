namespace Unity.Services.Analytics;

public class AcquisitionSourceEvent : Event
{

	public string AcquisitionCampaignId
	{
		 set { } //Length: 131
	}

	public string AcquisitionCampaignName
	{
		 set { } //Length: 131
	}

	public string AcquisitionCampaignType
	{
		 set { } //Length: 131
	}

	public string AcquisitionChannel
	{
		 set { } //Length: 131
	}

	public float AcquisitionCost
	{
		 set { } //Length: 135
	}

	public string AcquisitionCostCurrency
	{
		 set { } //Length: 131
	}

	public string AcquisitionCreativeId
	{
		 set { } //Length: 131
	}

	public string AcquisitionNetwork
	{
		 set { } //Length: 131
	}

	public string AcquisitionProvider
	{
		 set { } //Length: 131
	}

	public AcquisitionSourceEvent() { }

	public void set_AcquisitionCampaignId(string value) { }

	public void set_AcquisitionCampaignName(string value) { }

	public void set_AcquisitionCampaignType(string value) { }

	public void set_AcquisitionChannel(string value) { }

	public void set_AcquisitionCost(float value) { }

	public void set_AcquisitionCostCurrency(string value) { }

	public void set_AcquisitionCreativeId(string value) { }

	public void set_AcquisitionNetwork(string value) { }

	public void set_AcquisitionProvider(string value) { }

	public virtual void Validate() { }

}

