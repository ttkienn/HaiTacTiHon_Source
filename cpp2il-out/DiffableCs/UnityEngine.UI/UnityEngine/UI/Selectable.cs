namespace UnityEngine.UI;

[AddComponentMenu("UI/Selectable", 35)]
[DisallowMultipleComponent]
[ExecuteAlways]
[SelectionBase]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	internal enum SelectionState
	{
		Normal = 0,
		Highlighted = 1,
		Pressed = 2,
		Selected = 3,
		Disabled = 4,
	}

	internal enum Transition
	{
		None = 0,
		ColorTint = 1,
		SpriteSwap = 2,
		Animation = 3,
	}

	protected static Selectable[] s_Selectables; //Field offset: 0x0
	protected static int s_SelectableCount; //Field offset: 0x8
	private bool m_EnableCalled; //Field offset: 0x20
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	private Navigation m_Navigation; //Field offset: 0x28
	[FormerlySerializedAs("transition")]
	[SerializeField]
	private Transition m_Transition; //Field offset: 0x50
	[FormerlySerializedAs("colors")]
	[SerializeField]
	private ColorBlock m_Colors; //Field offset: 0x54
	[FormerlySerializedAs("spriteState")]
	[SerializeField]
	private SpriteState m_SpriteState; //Field offset: 0xB0
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	private AnimationTriggers m_AnimationTriggers; //Field offset: 0xD0
	[SerializeField]
	[Tooltip("Can the Selectable be interacted with?")]
	private bool m_Interactable; //Field offset: 0xD8
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[SerializeField]
	private Graphic m_TargetGraphic; //Field offset: 0xE0
	private bool m_GroupsAllowInteraction; //Field offset: 0xE8
	protected int m_CurrentIndex; //Field offset: 0xEC
	[CompilerGenerated]
	private bool <isPointerInside>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <isPointerDown>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	private bool <hasSelection>k__BackingField; //Field offset: 0xF2
	private readonly List<CanvasGroup> m_CanvasGroupCache; //Field offset: 0xF8

	public static int allSelectableCount
	{
		 get { } //Length: 78
	}

	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	public static List<Selectable> allSelectables
	{
		 get { } //Length: 255
	}

	public static Selectable[] allSelectablesArray
	{
		 get { } //Length: 143
	}

	public AnimationTriggers animationTriggers
	{
		 get { } //Length: 8
		 set { } //Length: 91
	}

	public Animator animator
	{
		 get { } //Length: 57
	}

	public ColorBlock colors
	{
		 get { } //Length: 62
		 set { } //Length: 154
	}

	protected SelectionState currentSelectionState
	{
		 get { } //Length: 100
	}

	private bool hasSelection
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Image image
	{
		 get { } //Length: 133
		 set { } //Length: 19
	}

	public bool interactable
	{
		 get { } //Length: 8
		 set { } //Length: 360
	}

	private bool isPointerDown
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool isPointerInside
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Navigation navigation
	{
		 get { } //Length: 29
		 set { } //Length: 118
	}

	public SpriteState spriteState
	{
		 get { } //Length: 25
		 set { } //Length: 110
	}

	public Graphic targetGraphic
	{
		 get { } //Length: 8
		 set { } //Length: 91
	}

	public Transition transition
	{
		 get { } //Length: 4
		 set { } //Length: 86
	}

	private static Selectable() { }

	protected Selectable() { }

	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	protected virtual void Awake() { }

	private void DoSpriteSwap(Sprite newSprite) { }

	protected override void DoStateTransition(SelectionState state, bool instant) { }

	private void EvaluateAndTransitionToSelectionState() { }

	public Selectable FindSelectable(Vector3 dir) { }

	public override Selectable FindSelectableOnDown() { }

	public override Selectable FindSelectableOnLeft() { }

	public override Selectable FindSelectableOnRight() { }

	public override Selectable FindSelectableOnUp() { }

	public static int get_allSelectableCount() { }

	public static List<Selectable> get_allSelectables() { }

	public static Selectable[] get_allSelectablesArray() { }

	public AnimationTriggers get_animationTriggers() { }

	public Animator get_animator() { }

	public ColorBlock get_colors() { }

	protected SelectionState get_currentSelectionState() { }

	[CompilerGenerated]
	private bool get_hasSelection() { }

	public Image get_image() { }

	public bool get_interactable() { }

	[CompilerGenerated]
	private bool get_isPointerDown() { }

	[CompilerGenerated]
	private bool get_isPointerInside() { }

	public Navigation get_navigation() { }

	public SpriteState get_spriteState() { }

	public Graphic get_targetGraphic() { }

	public Transition get_transition() { }

	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	protected override void InstantClearState() { }

	protected bool IsHighlighted() { }

	public override bool IsInteractable() { }

	protected bool IsPressed() { }

	private void Navigate(AxisEventData eventData, Selectable sel) { }

	private void OnApplicationFocus(bool hasFocus) { }

	protected virtual void OnCanvasGroupChanged() { }

	public override void OnDeselect(BaseEventData eventData) { }

	protected virtual void OnDidApplyAnimationProperties() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public override void OnMove(AxisEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	private void OnSetProperty() { }

	protected virtual void OnTransformParentChanged() { }

	private bool ParentGroupAllowsInteraction() { }

	public override void Select() { }

	public void set_animationTriggers(AnimationTriggers value) { }

	public void set_colors(ColorBlock value) { }

	[CompilerGenerated]
	private void set_hasSelection(bool value) { }

	public void set_image(Image value) { }

	public void set_interactable(bool value) { }

	[CompilerGenerated]
	private void set_isPointerDown(bool value) { }

	[CompilerGenerated]
	private void set_isPointerInside(bool value) { }

	public void set_navigation(Navigation value) { }

	public void set_spriteState(SpriteState value) { }

	public void set_targetGraphic(Graphic value) { }

	public void set_transition(Transition value) { }

	private void StartColorTween(Color targetColor, bool instant) { }

	private void TriggerAnimation(string triggername) { }

}

