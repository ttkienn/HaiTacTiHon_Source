namespace UnityEngine.Purchasing;

internal class AsyncDelayer : IAsyncDelayer
{

	public AsyncDelayer() { }

	[NullableContext(1)]
	public override Task Delay(int delayMilliseconds) { }

}

