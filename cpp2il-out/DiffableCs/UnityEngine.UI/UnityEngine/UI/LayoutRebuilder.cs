namespace UnityEngine.UI;

public class LayoutRebuilder : ICanvasElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Component> <>9__10_0; //Field offset: 0x8
		public static UnityAction<Component> <>9__12_0; //Field offset: 0x10
		public static UnityAction<Component> <>9__12_1; //Field offset: 0x18
		public static UnityAction<Component> <>9__12_2; //Field offset: 0x20
		public static UnityAction<Component> <>9__12_3; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal LayoutRebuilder <.cctor>b__5_0() { }

		internal void <.cctor>b__5_1(LayoutRebuilder x) { }

		internal void <Rebuild>b__12_0(Component e) { }

		internal void <Rebuild>b__12_1(Component e) { }

		internal void <Rebuild>b__12_2(Component e) { }

		internal void <Rebuild>b__12_3(Component e) { }

		internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	}

	private static ObjectPool<LayoutRebuilder> s_Rebuilders; //Field offset: 0x0
	private RectTransform m_ToRebuild; //Field offset: 0x10
	private int m_CachedHashFromTransform; //Field offset: 0x18

	public override Transform transform
	{
		 get { } //Length: 5
	}

	private static LayoutRebuilder() { }

	public LayoutRebuilder() { }

	private void Clear() { }

	public virtual bool Equals(object obj) { }

	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	public override Transform get_transform() { }

	public virtual int GetHashCode() { }

	public override void GraphicUpdateComplete() { }

	private void Initialize(RectTransform controller) { }

	public override bool IsDestroyed() { }

	public override void LayoutComplete() { }

	public static void MarkLayoutForRebuild(RectTransform rect) { }

	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	private static void ReapplyDrivenProperties(RectTransform driven) { }

	public override void Rebuild(CanvasUpdate executing) { }

	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	public virtual string ToString() { }

	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

}

