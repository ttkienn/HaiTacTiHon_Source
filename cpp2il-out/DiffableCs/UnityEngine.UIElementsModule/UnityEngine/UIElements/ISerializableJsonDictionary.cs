namespace UnityEngine.UIElements;

internal interface ISerializableJsonDictionary
{

	public bool ContainsKey(string key) { }

	public T Get(string key) { }

	public void Overwrite(object obj, string key) { }

	public void Set(string key, T value) { }

}

