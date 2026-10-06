namespace UnityEngine.Purchasing;

internal class DialogRequest
{
	public string QueryText; //Field offset: 0x10
	public string OkayButtonText; //Field offset: 0x18
	public string CancelButtonText; //Field offset: 0x20
	public List<String> Options; //Field offset: 0x28
	public Action<Boolean, Int32> Callback; //Field offset: 0x30

	public DialogRequest() { }

}

