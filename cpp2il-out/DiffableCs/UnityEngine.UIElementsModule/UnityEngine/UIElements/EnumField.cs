namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class EnumField : BaseField<Enum>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static EventCallback<MouseDownEvent> <>9__22_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__22_0(MouseDownEvent e) { }

	}

	internal class UxmlFactory : UxmlFactory<EnumField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits<Enum>
	{
		private UxmlTypeAttributeDescription<Enum> m_Type; //Field offset: 0x80
		private UxmlStringAttributeDescription m_Value; //Field offset: 0x88
		private UxmlBoolAttributeDescription m_IncludeObsoleteValues; //Field offset: 0x90

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string textUssClassName; //Field offset: 0x8
	public static readonly string arrowUssClassName; //Field offset: 0x10
	public static readonly string labelUssClassName; //Field offset: 0x18
	public static readonly string inputUssClassName; //Field offset: 0x20
	private Type m_EnumType; //Field offset: 0x448
	private bool m_IncludeObsoleteValues; //Field offset: 0x450
	private TextElement m_TextElement; //Field offset: 0x458
	private VisualElement m_ArrowElement; //Field offset: 0x460
	private EnumData m_EnumData; //Field offset: 0x468
	internal Func<IGenericMenu> createMenuCallback; //Field offset: 0x4A8

	internal bool includeObsoleteValues
	{
		internal get { } //Length: 8
	}

	private static EnumField() { }

	public EnumField() { }

	public EnumField(string label, Enum defaultValue = null) { }

	[CompilerGenerated]
	private void <ShowMenu>b__33_0(object contentView) { }

	private void ChangeValueFromMenu(object menuItem) { }

	private bool ContainsPointer(int pointerId) { }

	internal bool get_includeObsoleteValues() { }

	public void Init(Enum defaultValue, bool includeObsoleteValues) { }

	public void Init(Enum defaultValue) { }

	private void Initialize(Enum defaultValue) { }

	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	private void OnPointerDownEvent(PointerDownEvent evt) { }

	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	internal void PopulateDataFromType(Type enumType) { }

	private void ProcessPointerDown(PointerEventBase<T> evt) { }

	public virtual void SetValueWithoutNotify(Enum newValue) { }

	internal void ShowMenu() { }

	protected virtual void UpdateMixedValueContent() { }

	private void UpdateValueLabel(Enum value) { }

}

