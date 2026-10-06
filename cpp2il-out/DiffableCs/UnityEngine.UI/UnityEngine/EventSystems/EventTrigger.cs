namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Event Trigger")]
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
{
	internal class Entry
	{
		public EventTriggerType eventID; //Field offset: 0x10
		public TriggerEvent callback; //Field offset: 0x18

		public Entry() { }

	}

	internal class TriggerEvent : UnityEvent<BaseEventData>
	{

		public TriggerEvent() { }

	}

	[FormerlySerializedAs("delegates")]
	[SerializeField]
	private List<Entry> m_Delegates; //Field offset: 0x20

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	public List<Entry> delegates
	{
		 get { } //Length: 7
		 set { } //Length: 13
	}

	public List<Entry> triggers
	{
		 get { } //Length: 122
		 set { } //Length: 13
	}

	protected EventTrigger() { }

	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	public List<Entry> get_delegates() { }

	public List<Entry> get_triggers() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnCancel(BaseEventData eventData) { }

	public override void OnDeselect(BaseEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnDrop(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	public override void OnMove(AxisEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnScroll(PointerEventData eventData) { }

	public override void OnSelect(BaseEventData eventData) { }

	public override void OnSubmit(BaseEventData eventData) { }

	public override void OnUpdateSelected(BaseEventData eventData) { }

	public void set_delegates(List<Entry> value) { }

	public void set_triggers(List<Entry> value) { }

}

