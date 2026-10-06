namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class TextValueFieldTraits : BaseFieldTraits<TValueType, TValueUxmlAttributeType>
{
	private UxmlBoolAttributeDescription m_IsReadOnly; //Field offset: 0x0
	private UxmlBoolAttributeDescription m_IsDelayed; //Field offset: 0x0

	public TextValueFieldTraits`2() { }

	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

