namespace UnityEngine;

[IgnoredByDeepProfiler]
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI::SystemProfilerApi", StaticAccessorType::DoubleColon (2))]
public static class UISystemProfilerApi
{
	internal enum SampleType
	{
		Layout = 0,
		Render = 1,
	}


	public static void AddMarker(string name, object obj) { }

	public static void BeginSample(SampleType type) { }

	public static void EndSample(SampleType type) { }

}

