namespace UnityEngine.UIElements;

internal class PropagationPaths
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal PropagationPaths <.cctor>b__12_0() { }

	}

	private static readonly ObjectPool<PropagationPaths> s_Pool; //Field offset: 0x0
	private const int k_DefaultPropagationDepth = 16; //Field offset: 0x0
	private const int k_DefaultTargetCount = 4; //Field offset: 0x0
	public readonly List<VisualElement> trickleDownPath; //Field offset: 0x10
	public readonly List<VisualElement> targetElements; //Field offset: 0x18
	public readonly List<VisualElement> bubbleUpPath; //Field offset: 0x20

	private static PropagationPaths() { }

	public PropagationPaths() { }

	public static PropagationPaths Build(VisualElement elem, EventBase evt) { }

	public void Release() { }

}

