namespace UnityEngine.Purchasing;

internal class UnityActivity
{
	private const string k_AndroidClassName = "com.unity3d.player.UnityPlayer"; //Field offset: 0x0
	private static AndroidJavaClass s_UnityPlayerClass; //Field offset: 0x0

	public UnityActivity() { }

	internal static AndroidJavaObject GetCurrentActivity() { }

	private static AndroidJavaClass GetUnityPlayerClass() { }

}

