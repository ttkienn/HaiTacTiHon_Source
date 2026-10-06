namespace UnityEngine.UIElements;

internal interface IGroupManager
{

	public void Init(IGroupBox groupBox) { }

	public void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	public void RegisterOption(IGroupBoxOption option) { }

	public void UnregisterOption(IGroupBoxOption option) { }

}

