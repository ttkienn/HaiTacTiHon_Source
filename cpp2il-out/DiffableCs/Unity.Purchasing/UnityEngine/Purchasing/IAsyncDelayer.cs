namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IAsyncDelayer
{

	public Task Delay(int delayMilliseconds) { }

}

