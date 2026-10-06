namespace UnityEngine.UIElements;

public class RadioButtonGroup : BaseField<Int32>, IGroupBox
{
	internal class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : BaseFieldTraits<Int32, UxmlIntAttributeDescription>
	{
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0x88

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string containerUssClassName; //Field offset: 0x8
	private List<RadioButton> m_RadioButtons; //Field offset: 0x448
	private EventCallback<ChangeEvent`1<Boolean>> m_RadioButtonValueChangedCallback; //Field offset: 0x450
	private VisualElement m_RadioButtonContainer; //Field offset: 0x458

	public IEnumerable<String> choices
	{
		 set { } //Length: 1456
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 18
	}

	private static RadioButtonGroup() { }

	public RadioButtonGroup() { }

	public RadioButtonGroup(string label, List<String> radioButtonChoices = null) { }

	public virtual VisualElement get_contentContainer() { }

	private void RadioButtonValueChangedCallback(ChangeEvent<Boolean> evt) { }

	public void set_choices(IEnumerable<String> value) { }

	public virtual void SetValueWithoutNotify(int newValue) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	private void UpdateRadioButtons() { }

}

