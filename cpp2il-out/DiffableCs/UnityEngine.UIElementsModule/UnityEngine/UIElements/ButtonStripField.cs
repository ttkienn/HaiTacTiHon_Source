namespace UnityEngine.UIElements;

internal class ButtonStripField : BaseField<Int32>
{
	internal class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<Int32>
	{

		public UxmlTraits() { }

	}

	private List<Button> m_Buttons; //Field offset: 0x448

	public ButtonStripField() { }

	private void RefreshButtonsState() { }

	public virtual void SetValueWithoutNotify(int newValue) { }

}

