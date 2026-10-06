namespace UnityEngine.UIElements;

internal class NavigateFocusRing : IFocusRing
{
	internal class ChangeDirection : FocusChangeDirection
	{

		public ChangeDirection(int i) { }

	}

	private struct FocusableHierarchyTraversal
	{
		public VisualElement currentFocusable; //Field offset: 0x0
		public Rect validRect; //Field offset: 0x8
		public bool firstPass; //Field offset: 0x18
		public ChangeDirection direction; //Field offset: 0x20

		public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null) { }

		private int Order(VisualElement a, VisualElement b) { }

		private int StrictOrder(VisualElement a, VisualElement b) { }

		private int StrictOrder(Rect ra, Rect rb) { }

		private int TieBreaker(Rect ra, Rect rb) { }

		private bool ValidateElement(VisualElement v) { }

		private bool ValidateHierarchyTraversal(VisualElement v) { }

	}

	public static readonly ChangeDirection Left; //Field offset: 0x0
	public static readonly ChangeDirection Right; //Field offset: 0x8
	public static readonly ChangeDirection Up; //Field offset: 0x10
	public static readonly ChangeDirection Down; //Field offset: 0x18
	public static readonly FocusChangeDirection Next; //Field offset: 0x20
	public static readonly FocusChangeDirection Previous; //Field offset: 0x28
	private readonly VisualElement m_Root; //Field offset: 0x10
	private readonly VisualElementFocusRing m_Ring; //Field offset: 0x18

	private FocusController focusController
	{
		private get { } //Length: 42
	}

	private static NavigateFocusRing() { }

	public NavigateFocusRing(VisualElement root) { }

	private FocusController get_focusController() { }

	public override FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	public override Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction) { }

	private static bool IsActive(VisualElement v) { }

	private static bool IsNavigable(Focusable focusable) { }

}

