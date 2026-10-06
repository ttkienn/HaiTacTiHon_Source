namespace UnityEngine.UIElements;

public abstract class BaseBoolField : BaseField<Boolean>
{
	protected Label m_Label; //Field offset: 0x448
	protected readonly VisualElement m_CheckMark; //Field offset: 0x450
	internal Clickable m_Clickable; //Field offset: 0x458
	private string m_OriginalText; //Field offset: 0x460

	public string text
	{
		 get { } //Length: 47
		 set { } //Length: 172
	}

	public BaseBoolField(string label) { }

	public string get_text() { }

	protected override void InitLabel() { }

	private void OnClickEvent(EventBase evt) { }

	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	internal virtual void RegisterEditingCallbacks() { }

	public void set_text(string value) { }

	public virtual void SetValueWithoutNotify(bool newValue) { }

	protected override void ToggleValue() { }

	internal virtual void UnregisterEditingCallbacks() { }

	protected virtual void UpdateMixedValueContent() { }

}

