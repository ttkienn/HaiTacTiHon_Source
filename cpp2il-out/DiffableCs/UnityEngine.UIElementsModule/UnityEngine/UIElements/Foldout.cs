namespace UnityEngine.UIElements;

public class Foldout : BindableElement, INotifyValueChanged<Boolean>
{
	internal class UxmlFactory : UxmlFactory<Foldout, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x78
		private UxmlBoolAttributeDescription m_Value; //Field offset: 0x80

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string toggleUssClassName; //Field offset: 0x8
	public static readonly string contentUssClassName; //Field offset: 0x10
	public static readonly string inputUssClassName; //Field offset: 0x18
	public static readonly string checkmarkUssClassName; //Field offset: 0x20
	public static readonly string textUssClassName; //Field offset: 0x28
	internal static readonly string toggleInspectorUssClassName; //Field offset: 0x30
	internal static readonly string ussFoldoutDepthClassName; //Field offset: 0x38
	internal static readonly int ussFoldoutMaxDepth; //Field offset: 0x40
	private Toggle m_Toggle; //Field offset: 0x3D8
	private VisualElement m_Container; //Field offset: 0x3E0
	[SerializeField]
	private bool m_Value; //Field offset: 0x3E8
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x3F0

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 8
	}

	public string text
	{
		 set { } //Length: 291
	}

	internal Toggle toggle
	{
		internal get { } //Length: 8
	}

	public override bool value
	{
		 get { } //Length: 8
		 set { } //Length: 323
	}

	private static Foldout() { }

	public Foldout() { }

	[CompilerGenerated]
	private void <.ctor>b__29_0(ChangeEvent<Boolean> evt) { }

	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	private bool Apply(KeyboardNavigationOperation op) { }

	public virtual VisualElement get_contentContainer() { }

	internal Toggle get_toggle() { }

	public override bool get_value() { }

	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	internal virtual void OnViewDataReady() { }

	public void set_text(string value) { }

	public override void set_value(bool value) { }

	public override void SetValueWithoutNotify(bool newValue) { }

}

