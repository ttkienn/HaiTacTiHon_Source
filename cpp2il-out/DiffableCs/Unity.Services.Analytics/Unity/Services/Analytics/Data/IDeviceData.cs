namespace Unity.Services.Analytics.Data;

internal interface IDeviceData
{

	public int CpuCores
	{
		 get { } //Length: 0
	}

	public string CpuType
	{
		 get { } //Length: 0
	}

	public string DeviceModel
	{
		 get { } //Length: 0
	}

	public string GpuType
	{
		 get { } //Length: 0
	}

	public bool IsDebugDevice
	{
		 get { } //Length: 0
	}

	public bool IsTiny
	{
		 get { } //Length: 0
	}

	public string OperatingSystem
	{
		 get { } //Length: 0
	}

	public int RamTotal
	{
		 get { } //Length: 0
	}

	public float ScreenDpi
	{
		 get { } //Length: 0
	}

	public int ScreenHeight
	{
		 get { } //Length: 0
	}

	public int ScreenWidth
	{
		 get { } //Length: 0
	}

	public int get_CpuCores() { }

	public string get_CpuType() { }

	public string get_DeviceModel() { }

	public string get_GpuType() { }

	public bool get_IsDebugDevice() { }

	public bool get_IsTiny() { }

	public string get_OperatingSystem() { }

	public int get_RamTotal() { }

	public float get_ScreenDpi() { }

	public int get_ScreenHeight() { }

	public int get_ScreenWidth() { }

}

