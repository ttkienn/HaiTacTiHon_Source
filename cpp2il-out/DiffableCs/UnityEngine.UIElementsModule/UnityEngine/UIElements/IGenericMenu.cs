namespace UnityEngine.UIElements;

internal interface IGenericMenu
{

	public void AddItem(string itemName, bool isChecked, Action action) { }

	public void AddItem(string itemName, bool isChecked, Action<Object> action, object data) { }

	public void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false) { }

}

