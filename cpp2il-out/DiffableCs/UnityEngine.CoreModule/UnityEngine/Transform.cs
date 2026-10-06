namespace UnityEngine;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[NativeHeader("Configuration/UnityConfigure.h")]
[NativeHeader("Runtime/Transform/Transform.h")]
[RequiredByNativeCode]
public class Transform : Component, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private Transform outer; //Field offset: 0x10
		private int currentIndex; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 76
		}

		internal Enumerator(Transform outer) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	public int childCount
	{
		[NativeMethod("GetChildrenCount")]
		 get { } //Length: 51
	}

	public Vector3 forward
	{
		 get { } //Length: 557
	}

	public Vector3 localPosition
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Quaternion localRotation
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public Vector3 localScale
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Matrix4x4 localToWorldMatrix
	{
		 get { } //Length: 87
	}

	public Transform parent
	{
		 get { } //Length: 51
		 set { } //Length: 186
	}

	internal Transform parentInternal
	{
		internal get { } //Length: 51
		internal set { } //Length: 69
	}

	public Vector3 position
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Quaternion rotation
	{
		 get { } //Length: 75
	}

	public Matrix4x4 worldToLocalMatrix
	{
		 get { } //Length: 87
	}

	protected Transform() { }

	[NativeMethod("GetChildrenCount")]
	public int get_childCount() { }

	public Vector3 get_forward() { }

	public Vector3 get_localPosition() { }

	private void get_localPosition_Injected(out Vector3 ret) { }

	public Quaternion get_localRotation() { }

	private void get_localRotation_Injected(out Quaternion ret) { }

	public Vector3 get_localScale() { }

	private void get_localScale_Injected(out Vector3 ret) { }

	public Matrix4x4 get_localToWorldMatrix() { }

	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	public Transform get_parent() { }

	internal Transform get_parentInternal() { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	public Matrix4x4 get_worldToLocalMatrix() { }

	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	[FreeFunction("GetChild", HasExplicitThis = True)]
	[NativeThrows]
	public Transform GetChild(int index) { }

	public override IEnumerator GetEnumerator() { }

	private Transform GetParent() { }

	public Vector3 InverseTransformPoint(Vector3 position) { }

	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	public bool IsChildOf(Transform parent) { }

	public void set_localPosition(Vector3 value) { }

	private void set_localPosition_Injected(ref Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	private void set_localRotation_Injected(ref Quaternion value) { }

	public void set_localScale(Vector3 value) { }

	private void set_localScale_Injected(ref Vector3 value) { }

	public void set_parent(Transform value) { }

	internal void set_parentInternal(Transform value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void SetAsFirstSibling() { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	public void SetParent(Transform parent, bool worldPositionStays) { }

	public void SetParent(Transform p) { }

	public Vector3 TransformPoint(Vector3 position) { }

	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

}

