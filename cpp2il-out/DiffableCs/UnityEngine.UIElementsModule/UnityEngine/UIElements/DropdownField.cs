namespace UnityEngine.UIElements;

public class DropdownField : PopupField<String>
{
	internal class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<String>
	{
		private UxmlIntAttributeDescription m_Index; //Field offset: 0x80
		private UxmlStringAttributeDescription m_Choices; //Field offset: 0x88

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}


	public DropdownField() { }

	public DropdownField(string label) { }

}

