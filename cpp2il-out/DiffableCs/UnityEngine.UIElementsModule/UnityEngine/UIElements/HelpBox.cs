namespace UnityEngine.UIElements;

public class HelpBox : VisualElement
{
	internal class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x70
		private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType; //Field offset: 0x78

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string iconUssClassName; //Field offset: 0x10
	public static readonly string iconInfoUssClassName; //Field offset: 0x18
	public static readonly string iconwarningUssClassName; //Field offset: 0x20
	public static readonly string iconErrorUssClassName; //Field offset: 0x28
	private HelpBoxMessageType m_HelpBoxMessageType; //Field offset: 0x3C8
	private VisualElement m_Icon; //Field offset: 0x3D0
	private string m_IconClass; //Field offset: 0x3D8
	private Label m_Label; //Field offset: 0x3E0

	public HelpBoxMessageType messageType
	{
		 set { } //Length: 23
	}

	public string text
	{
		 set { } //Length: 45
	}

	private static HelpBox() { }

	public HelpBox() { }

	public HelpBox(string text, HelpBoxMessageType messageType) { }

	private string GetIconClass(HelpBoxMessageType messageType) { }

	public void set_messageType(HelpBoxMessageType value) { }

	public void set_text(string value) { }

	private void UpdateIcon(HelpBoxMessageType messageType) { }

}

