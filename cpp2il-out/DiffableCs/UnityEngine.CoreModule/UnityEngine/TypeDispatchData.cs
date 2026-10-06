namespace UnityEngine;

internal struct TypeDispatchData : IDisposable
{
	public Object[] changed; //Field offset: 0x0
	public NativeArray<Int32> changedID; //Field offset: 0x8
	public NativeArray<Int32> destroyedID; //Field offset: 0x18

	public override void Dispose() { }

}

