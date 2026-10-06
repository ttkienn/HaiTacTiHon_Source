namespace UnityEngine.UIElements;

public class RadioButton : BaseBoolField, IGroupBoxOption
{
	internal class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : BaseFieldTraits<Boolean, UxmlBoolAttributeDescription>
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x88

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10
	public static readonly string checkmarkBackgroundUssClassName; //Field offset: 0x18
	public static readonly string checkmarkUssClassName; //Field offset: 0x20
	public static readonly string textUssClassName; //Field offset: 0x28
	private VisualElement m_CheckmarkBackground; //Field offset: 0x468

	public virtual bool value
	{
		 get { } //Length: 57
		 set { } //Length: 181
	}

	private static RadioButton() { }

	public RadioButton() { }

	public RadioButton(string label) { }

	public virtual bool get_value() { }

	protected virtual void InitLabel() { }

	private void OnOptionAttachToPanel(AttachToPanelEvent evt) { }

	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt) { }

	public virtual void set_value(bool value) { }

	public virtual void SetValueWithoutNotify(bool newValue) { }

	protected virtual void ToggleValue() { }

	private override void UnityEngine.UIElements.IGroupBoxOption.SetSelected(bool selected) { }

	private void UpdateCheckmark() { }

	protected virtual void UpdateMixedValueContent() { }

}

