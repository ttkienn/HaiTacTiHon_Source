namespace UnityEngine.UIElements;

internal interface IEditableElement
{

	internal Action editingEnded
	{
		internal get { } //Length: 0
	}

	internal Action editingStarted
	{
		internal get { } //Length: 0
	}

	internal Action get_editingEnded() { }

	internal Action get_editingStarted() { }

}

