namespace UnityEngine.Experimental.GlobalIllumination;

public static class Lightmapping
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	}

	internal sealed class RequestLightsDelegate : MulticastDelegate
	{

		public RequestLightsDelegate(object object, IntPtr method) { }

		public override void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	}

	[RequiredByNativeCode]
	private static readonly RequestLightsDelegate s_DefaultDelegate; //Field offset: 0x0
	[RequiredByNativeCode]
	private static RequestLightsDelegate s_RequestLightsDelegate; //Field offset: 0x8

	private static Lightmapping() { }

	[RequiredByNativeCode]
	public static RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCode]
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	[RequiredByNativeCode]
	public static void ResetDelegate() { }

	[RequiredByNativeCode]
	public static void SetDelegate(RequestLightsDelegate del) { }

}

