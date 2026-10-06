namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
public class TextStyleSheet : ScriptableObject
{
	[SerializeField]
	private List<TextStyle> m_StyleList; //Field offset: 0x18
	private Dictionary<Int32, TextStyle> m_StyleLookupDictionary; //Field offset: 0x20

	internal List<TextStyle> styles
	{
		internal get { } //Length: 7
	}

	public TextStyleSheet() { }

	internal List<TextStyle> get_styles() { }

	public TextStyle GetStyle(int hashCode) { }

	public TextStyle GetStyle(string name) { }

	private void LoadStyleDictionaryInternal() { }

	public void RefreshStyles() { }

	private void Reset() { }

}

