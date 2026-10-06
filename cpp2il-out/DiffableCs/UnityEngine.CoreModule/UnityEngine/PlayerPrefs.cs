namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
public class PlayerPrefs
{

	[NativeMethod("DeleteAllWithCallback")]
	public static void DeleteAll() { }

	public static void DeleteKey(string key) { }

	public static int GetInt(string key, int defaultValue) { }

	public static int GetInt(string key) { }

	public static string GetString(string key, string defaultValue) { }

	public static string GetString(string key) { }

	public static bool HasKey(string key) { }

	[NativeMethod("Sync")]
	public static void Save() { }

	public static void SetInt(string key, int value) { }

	public static void SetString(string key, string value) { }

	[NativeMethod("SetInt")]
	private static bool TrySetInt(string key, int value) { }

	[NativeMethod("SetString")]
	private static bool TrySetSetString(string key, string value) { }

}

