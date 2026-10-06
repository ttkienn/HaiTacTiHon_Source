namespace Unity.Services.Analytics.Data;

internal interface ICommonData
{

	public string AnalyticsRegionLanguageCode
	{
		 get { } //Length: 0
	}

	public double BatteryLevel
	{
		 get { } //Length: 0
	}

	public string BuildGUID
	{
		 get { } //Length: 0
	}

	public string GameBundleId
	{
		 get { } //Length: 0
	}

	public string GameStoreId
	{
		 get { } //Length: 0
	}

	public bool HasVolume
	{
		 get { } //Length: 0
	}

	public string Idfv
	{
		 get { } //Length: 0
	}

	public string Platform
	{
		 get { } //Length: 0
	}

	public string ProjectId
	{
		 get { } //Length: 0
	}

	public string Version
	{
		 get { } //Length: 0
	}

	public float Volume
	{
		 get { } //Length: 0
	}

	public string get_AnalyticsRegionLanguageCode() { }

	public double get_BatteryLevel() { }

	public string get_BuildGUID() { }

	public string get_GameBundleId() { }

	public string get_GameStoreId() { }

	public bool get_HasVolume() { }

	public string get_Idfv() { }

	public string get_Platform() { }

	public string get_ProjectId() { }

	public string get_Version() { }

	public float get_Volume() { }

}

