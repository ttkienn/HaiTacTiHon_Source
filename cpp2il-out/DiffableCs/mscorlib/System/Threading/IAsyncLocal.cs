namespace System.Threading;

internal interface IAsyncLocal
{

	public void OnValueChanged(object previousValue, object currentValue, bool contextChanged) { }

}

