namespace UnityEngine.UIElements;

public class TextField : TextInputBaseField<String>
{
	private class TextInput : TextInputBase<String>
	{

		public virtual bool isPasswordField
		{
			 set { } //Length: 92
		}

		public bool multiline
		{
			 set { } //Length: 486
		}

		public TextInput() { }

		public virtual void set_isPasswordField(bool value) { }

		public void set_multiline(bool value) { }

		protected virtual string StringToValue(string str) { }

	}

	internal class UxmlFactory : UxmlFactory<TextField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<String>
	{
		private static readonly UxmlStringAttributeDescription k_Value; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Multiline; //Field offset: 0xC8

		private static UxmlTraits() { }

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	public bool multiline
	{
		 set { } //Length: 45
	}

	private TextInput textInput
	{
		private get { } //Length: 122
	}

	public virtual string value
	{
		 get { } //Length: 57
		 set { } //Length: 174
	}

	private static TextField() { }

	public TextField() { }

	public TextField(string label) { }

	public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(BlurEvent)}])]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	private TextInput get_textInput() { }

	public virtual string get_value() { }

	internal virtual void OnViewDataReady() { }

	public void set_multiline(bool value) { }

	public virtual void set_value(string value) { }

	public virtual void SetValueWithoutNotify(string newValue) { }

	protected virtual string StringToValue(string str) { }

	internal virtual void UpdateTextFromValue() { }

	protected virtual string ValueToString(string value) { }

}

