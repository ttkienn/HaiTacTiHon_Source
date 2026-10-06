namespace UnityEngine.UI;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
{
	[CompilerGenerated]
	private sealed class <DelayedSetDirty>d__56 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RectTransform rectTransform; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <DelayedSetDirty>d__56(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	protected RectOffset m_Padding; //Field offset: 0x20
	[SerializeField]
	protected TextAnchor m_ChildAlignment; //Field offset: 0x28
	private RectTransform m_Rect; //Field offset: 0x30
	protected DrivenRectTransformTracker m_Tracker; //Field offset: 0x38
	private Vector2 m_TotalMinSize; //Field offset: 0x3C
	private Vector2 m_TotalPreferredSize; //Field offset: 0x44
	private Vector2 m_TotalFlexibleSize; //Field offset: 0x4C
	private List<RectTransform> m_RectChildren; //Field offset: 0x58

	public TextAnchor childAlignment
	{
		 get { } //Length: 4
		 set { } //Length: 75
	}

	public override float flexibleHeight
	{
		 get { } //Length: 8
	}

	public override float flexibleWidth
	{
		 get { } //Length: 8
	}

	private bool isRootLayoutGroup
	{
		private get { } //Length: 294
	}

	public override int layoutPriority
	{
		 get { } //Length: 3
	}

	public override float minHeight
	{
		 get { } //Length: 8
	}

	public override float minWidth
	{
		 get { } //Length: 8
	}

	public RectOffset padding
	{
		 get { } //Length: 5
		 set { } //Length: 76
	}

	public override float preferredHeight
	{
		 get { } //Length: 8
	}

	public override float preferredWidth
	{
		 get { } //Length: 8
	}

	protected List<RectTransform> rectChildren
	{
		 get { } //Length: 5
	}

	protected RectTransform rectTransform
	{
		 get { } //Length: 141
	}

	protected LayoutGroup() { }

	public override void CalculateLayoutInputHorizontal() { }

	public abstract void CalculateLayoutInputVertical() { }

	[IteratorStateMachine(typeof(<DelayedSetDirty>d__56))]
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }

	public TextAnchor get_childAlignment() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	private bool get_isRootLayoutGroup() { }

	public override int get_layoutPriority() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public RectOffset get_padding() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	protected List<RectTransform> get_rectChildren() { }

	protected RectTransform get_rectTransform() { }

	protected float GetAlignmentOnAxis(int axis) { }

	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	protected float GetTotalFlexibleSize(int axis) { }

	protected float GetTotalMinSize(int axis) { }

	protected float GetTotalPreferredSize(int axis) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnRectTransformDimensionsChange() { }

	protected override void OnTransformChildrenChanged() { }

	public void set_childAlignment(TextAnchor value) { }

	public void set_padding(RectOffset value) { }

	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	protected void SetDirty() { }

	public abstract void SetLayoutHorizontal() { }

	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	public abstract void SetLayoutVertical() { }

	protected void SetProperty(ref T currentValue, T newValue) { }

}

