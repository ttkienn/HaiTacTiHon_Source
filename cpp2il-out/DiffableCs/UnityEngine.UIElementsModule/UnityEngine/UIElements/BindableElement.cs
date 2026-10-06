namespace UnityEngine.UIElements;

public class BindableElement : VisualElement, IBindable
{
	internal class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_PropertyPath; //Field offset: 0x70

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IBinding <binding>k__BackingField; //Field offset: 0x3C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <bindingPath>k__BackingField; //Field offset: 0x3D0

	public override IBinding binding
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override string bindingPath
	{
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public BindableElement() { }

	[CompilerGenerated]
	public override IBinding get_binding() { }

	[CompilerGenerated]
	public override void set_bindingPath(string value) { }

}

