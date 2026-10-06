namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType::Dot (0))]
public class Time
{

	public static float deltaTime
	{
		 get { } //Length: 42
	}

	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup
	{
		 get { } //Length: 42
	}

	[NativeProperty("CurTime")]
	public static float time
	{
		 get { } //Length: 42
	}

	public static float timeScale
	{
		 set { } //Length: 58
	}

	public static float unscaledDeltaTime
	{
		 get { } //Length: 42
	}

	public static float unscaledTime
	{
		 get { } //Length: 42
	}

	public static float get_deltaTime() { }

	public static float get_realtimeSinceStartup() { }

	public static float get_time() { }

	public static float get_unscaledDeltaTime() { }

	public static float get_unscaledTime() { }

	public static void set_timeScale(float value) { }

}

