namespace UnityEngine.UIElements;

public class TemplateContainer : BindableElement
{
	internal class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits>
	{

		public virtual string uxmlName
		{
			 get { } //Length: 44
		}

		public virtual string uxmlQualifiedName
		{
			 get { } //Length: 120
		}

		public UxmlFactory() { }

		public virtual string get_uxmlName() { }

		public virtual string get_uxmlQualifiedName() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Template; //Field offset: 0x78

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <templateId>k__BackingField; //Field offset: 0x3D8
	private VisualElement m_ContentContainer; //Field offset: 0x3E0
	private VisualTreeAsset m_TemplateSource; //Field offset: 0x3E8

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 10
	}

	public private string templateId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 19
	}

	internal VisualTreeAsset templateSource
	{
		internal set { } //Length: 19
	}

	public TemplateContainer() { }

	public TemplateContainer(string templateId) { }

	public virtual VisualElement get_contentContainer() { }

	[CompilerGenerated]
	public string get_templateId() { }

	[CompilerGenerated]
	private void set_templateId(string value) { }

	internal void set_templateSource(VisualTreeAsset value) { }

	internal void SetContentContainer(VisualElement content) { }

}

