namespace UnityEngine.UIElements.StyleSheets;

[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
internal struct StyleValue
{
	public StylePropertyId id; //Field offset: 0x0
	public StyleKeyword keyword; //Field offset: 0x4
	public float number; //Field offset: 0x8
	public Length length; //Field offset: 0x8
	public Color color; //Field offset: 0x8
	public GCHandle resource; //Field offset: 0x8
	public BackgroundPosition position; //Field offset: 0x8
	public BackgroundRepeat repeat; //Field offset: 0x8

}

