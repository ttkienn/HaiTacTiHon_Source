namespace UnityEngine.UIElements;

public interface ITextEdition
{

	internal Func<Char, Boolean> AcceptCharacter
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	public bool autoCorrection
	{
		 get { } //Length: 171
		 set { } //Length: 168
	}

	public bool hideMobileInput
	{
		 get { } //Length: 171
		 set { } //Length: 168
	}

	public bool isDelayed
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool isPassword
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool isReadOnly
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TouchScreenKeyboardType keyboardType
	{
		 get { } //Length: 171
		 set { } //Length: 168
	}

	public char maskChar
	{
		 set { } //Length: 0
	}

	public int maxLength
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal Action MoveFocusToCompositeRoot
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal bool multiline
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal Action<Boolean> UpdateScrollOffset
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal Action UpdateTextFromValue
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal Action UpdateValueFromText
	{
		internal get { } //Length: 0
		internal set { } //Length: 0
	}

	internal string CullString(string s) { }

	internal Func<Char, Boolean> get_AcceptCharacter() { }

	public bool get_autoCorrection() { }

	public bool get_hideMobileInput() { }

	public bool get_isDelayed() { }

	public bool get_isPassword() { }

	public bool get_isReadOnly() { }

	public TouchScreenKeyboardType get_keyboardType() { }

	public int get_maxLength() { }

	internal Action get_MoveFocusToCompositeRoot() { }

	internal bool get_multiline() { }

	internal Action<Boolean> get_UpdateScrollOffset() { }

	internal Action get_UpdateTextFromValue() { }

	internal Action get_UpdateValueFromText() { }

	internal void RestoreValueAndText() { }

	internal void SaveValueAndText() { }

	internal void set_AcceptCharacter(Func<Char, Boolean> value) { }

	public void set_autoCorrection(bool value) { }

	public void set_hideMobileInput(bool value) { }

	public void set_isDelayed(bool value) { }

	public void set_isPassword(bool value) { }

	public void set_isReadOnly(bool value) { }

	public void set_keyboardType(TouchScreenKeyboardType value) { }

	public void set_maskChar(char value) { }

	public void set_maxLength(int value) { }

	internal void set_MoveFocusToCompositeRoot(Action value) { }

	internal void set_multiline(bool value) { }

	internal void set_UpdateScrollOffset(Action<Boolean> value) { }

	internal void set_UpdateTextFromValue(Action value) { }

	internal void set_UpdateValueFromText(Action value) { }

	internal void UpdateText(string value) { }

}

