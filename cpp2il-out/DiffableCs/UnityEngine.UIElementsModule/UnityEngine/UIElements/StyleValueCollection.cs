namespace UnityEngine.UIElements;

internal class StyleValueCollection
{
	internal List<StyleValue> m_Values; //Field offset: 0x10

	public StyleValueCollection() { }

	public StyleFloat GetStyleFloat(StylePropertyId id) { }

	public StyleInt GetStyleInt(StylePropertyId id) { }

	public StyleLength GetStyleLength(StylePropertyId id) { }

	public void SetStyleValue(StyleValue value) { }

	public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value) { }

}

