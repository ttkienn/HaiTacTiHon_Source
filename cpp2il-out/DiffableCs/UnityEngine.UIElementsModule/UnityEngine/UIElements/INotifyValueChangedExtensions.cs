namespace UnityEngine.UIElements;

[Extension]
public static class INotifyValueChangedExtensions
{

	[Extension]
	public static bool RegisterValueChangedCallback(INotifyValueChanged<T> control, EventCallback<ChangeEvent`1<T>> callback) { }

	[Extension]
	public static bool UnregisterValueChangedCallback(INotifyValueChanged<T> control, EventCallback<ChangeEvent`1<T>> callback) { }

}

