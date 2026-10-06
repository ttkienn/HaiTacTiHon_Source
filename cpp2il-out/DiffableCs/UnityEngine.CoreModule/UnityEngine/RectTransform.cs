namespace UnityEngine;

[NativeClass("UI::RectTransform")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
public sealed class RectTransform : Transform
{
	internal enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	internal sealed class ReapplyDrivenProperties : MulticastDelegate
	{

		public ReapplyDrivenProperties(object object, IntPtr method) { }

		public override void Invoke(RectTransform driven) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ReapplyDrivenProperties reapplyDrivenProperties; //Field offset: 0x0

	public static event ReapplyDrivenProperties reapplyDrivenProperties
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public Vector2 anchoredPosition
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public Vector2 anchorMax
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public Vector2 anchorMin
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public Vector2 offsetMax
	{
		 set { } //Length: 567
	}

	public Vector2 offsetMin
	{
		 set { } //Length: 618
	}

	public Vector2 pivot
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public Rect rect
	{
		 get { } //Length: 75
	}

	public Vector2 sizeDelta
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public RectTransform() { }

	[CompilerGenerated]
	public static void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	public Vector2 get_anchoredPosition() { }

	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	public Vector2 get_anchorMax() { }

	private void get_anchorMax_Injected(out Vector2 ret) { }

	public Vector2 get_anchorMin() { }

	private void get_anchorMin_Injected(out Vector2 ret) { }

	public Vector2 get_pivot() { }

	private void get_pivot_Injected(out Vector2 ret) { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public Vector2 get_sizeDelta() { }

	private void get_sizeDelta_Injected(out Vector2 ret) { }

	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	private Vector2 GetParentSize() { }

	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	[CompilerGenerated]
	public static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	[RequiredByNativeCode]
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	public void set_anchoredPosition(Vector2 value) { }

	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	public void set_anchorMax(Vector2 value) { }

	private void set_anchorMax_Injected(ref Vector2 value) { }

	public void set_anchorMin(Vector2 value) { }

	private void set_anchorMin_Injected(ref Vector2 value) { }

	public void set_offsetMax(Vector2 value) { }

	public void set_offsetMin(Vector2 value) { }

	public void set_pivot(Vector2 value) { }

	private void set_pivot_Injected(ref Vector2 value) { }

	public void set_sizeDelta(Vector2 value) { }

	private void set_sizeDelta_Injected(ref Vector2 value) { }

	public void SetSizeWithCurrentAnchors(Axis axis, float size) { }

}

