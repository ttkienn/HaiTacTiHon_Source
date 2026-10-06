namespace UnityEngine;

[NativeHeader("Runtime/Input/LocationService.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
public class LocationService
{

	public bool isEnabledByUser
	{
		 get { } //Length: 42
	}

	public LocationInfo lastData
	{
		 get { } //Length: 209
	}

	public LocationServiceStatus status
	{
		 get { } //Length: 42
	}

	public LocationService() { }

	public bool get_isEnabledByUser() { }

	public LocationInfo get_lastData() { }

	public LocationServiceStatus get_status() { }

	[FreeFunction("LocationService::GetLastLocation")]
	internal static LocationInfo GetLastLocation() { }

	private static void GetLastLocation_Injected(out LocationInfo ret) { }

	[FreeFunction("LocationService::GetLocationStatus")]
	internal static LocationServiceStatus GetLocationStatus() { }

	[FreeFunction("LocationService::IsServiceEnabledByUser")]
	internal static bool IsServiceEnabledByUser() { }

	[FreeFunction("LocationService::SetDesiredAccuracy")]
	internal static void SetDesiredAccuracy(float value) { }

	[FreeFunction("LocationService::SetDistanceFilter")]
	internal static void SetDistanceFilter(float value) { }

	public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters) { }

	[FreeFunction("LocationService::StartUpdatingLocation")]
	internal static void StartUpdatingLocation() { }

}

