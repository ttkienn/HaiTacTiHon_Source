namespace UnityEngine.UIElements;

public class GroupBox : BindableElement, IGroupBox
{
	internal class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x78

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	private Label m_TitleLabel; //Field offset: 0x3D8

	public string text
	{
		 set { } //Length: 343
	}

	private static GroupBox() { }

	public GroupBox() { }

	public GroupBox(string text) { }

	public void set_text(string value) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

}

