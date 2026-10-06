namespace UnityEngine.Purchasing.MiniJSON;

[Extension]
public static class MiniJsonExtensions
{

	[Extension]
	public static List<Object> ArrayListFromJson(string json) { }

	[Extension]
	public static T Get(Dictionary<String, Object> dic, string key) { }

	[Extension]
	public static bool GetBool(Dictionary<String, Object> dic, string key) { }

	[Extension]
	public static T GetEnum(Dictionary<String, Object> dic, string key) { }

	[Extension]
	public static Dictionary<String, Object> GetHash(Dictionary<String, Object> dic, string key) { }

	[Extension]
	public static long GetLong(Dictionary<String, Object> dic, string key) { }

	[Extension]
	public static string GetString(Dictionary<String, Object> dic, string key, string defaultValue = "") { }

	[Extension]
	public static List<String> GetStringList(Dictionary<String, Object> dic, string key) { }

	[Extension]
	public static Dictionary<String, Object> HashtableFromJson(string json) { }

	[Extension]
	public static string toJson(Dictionary<String, Object> obj) { }

	[Extension]
	public static string toJson(Dictionary<String, String> obj) { }

	[Extension]
	public static string toJson(String[] array) { }

}

