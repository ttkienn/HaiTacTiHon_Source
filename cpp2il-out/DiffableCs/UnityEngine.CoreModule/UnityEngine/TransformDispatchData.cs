namespace UnityEngine;

internal struct TransformDispatchData : IDisposable
{
	public NativeArray<Int32> transformedID; //Field offset: 0x0
	public NativeArray<Int32> parentID; //Field offset: 0x10
	public NativeArray<Matrix4x4> localToWorldMatrices; //Field offset: 0x20
	public NativeArray<Vector3> positions; //Field offset: 0x30
	public NativeArray<Quaternion> rotations; //Field offset: 0x40
	public NativeArray<Vector3> scales; //Field offset: 0x50

	public override void Dispose() { }

}

