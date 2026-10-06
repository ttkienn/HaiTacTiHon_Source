namespace UnityEngine.UIElements;

[HelpURL("UIE-USS")]
public class StyleSheet : ScriptableObject
{
	public struct ImportStruct
	{
		public StyleSheet styleSheet; //Field offset: 0x0
		public String[] mediaQueries; //Field offset: 0x8

	}

	private static string kCustomPropertyMarker; //Field offset: 0x0
	[SerializeField]
	private bool m_ImportedWithErrors; //Field offset: 0x18
	[SerializeField]
	private bool m_ImportedWithWarnings; //Field offset: 0x19
	[SerializeField]
	private StyleRule[] m_Rules; //Field offset: 0x20
	[SerializeField]
	private StyleComplexSelector[] m_ComplexSelectors; //Field offset: 0x28
	[SerializeField]
	internal Single[] floats; //Field offset: 0x30
	[SerializeField]
	internal Dimension[] dimensions; //Field offset: 0x38
	[SerializeField]
	internal Color[] colors; //Field offset: 0x40
	[SerializeField]
	internal String[] strings; //Field offset: 0x48
	[SerializeField]
	internal Object[] assets; //Field offset: 0x50
	[SerializeField]
	internal ImportStruct[] imports; //Field offset: 0x58
	[SerializeField]
	private List<StyleSheet> m_FlattenedImportedStyleSheets; //Field offset: 0x60
	[SerializeField]
	private int m_ContentHash; //Field offset: 0x68
	[SerializeField]
	internal ScalableImage[] scalableImages; //Field offset: 0x70
	internal Dictionary<String, StyleComplexSelector> orderedNameSelectors; //Field offset: 0x78
	internal Dictionary<String, StyleComplexSelector> orderedTypeSelectors; //Field offset: 0x80
	internal Dictionary<String, StyleComplexSelector> orderedClassSelectors; //Field offset: 0x88
	private bool m_IsDefaultStyleSheet; //Field offset: 0x90

	internal StyleComplexSelector[] complexSelectors
	{
		internal get { } //Length: 7
		internal set { } //Length: 37
	}

	public int contentHash
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	internal List<StyleSheet> flattenedRecursiveImports
	{
		internal get { } //Length: 7
	}

	public internal bool importedWithErrors
	{
		 get { } //Length: 7
		internal set { } //Length: 4
	}

	public internal bool importedWithWarnings
	{
		 get { } //Length: 7
		internal set { } //Length: 4
	}

	internal bool isDefaultStyleSheet
	{
		internal get { } //Length: 10
		internal set { } //Length: 271
	}

	internal StyleRule[] rules
	{
		internal get { } //Length: 7
		internal set { } //Length: 37
	}

	private static StyleSheet() { }

	public StyleSheet() { }

	private T CheckAccess(T[] list, StyleValueType type, StyleValueHandle handle) { }

	private static bool CustomStartsWith(string originalString, string pattern) { }

	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	internal void FlattenImportedStyleSheetsRecursive() { }

	internal StyleComplexSelector[] get_complexSelectors() { }

	public int get_contentHash() { }

	internal List<StyleSheet> get_flattenedRecursiveImports() { }

	public bool get_importedWithErrors() { }

	public bool get_importedWithWarnings() { }

	internal bool get_isDefaultStyleSheet() { }

	internal StyleRule[] get_rules() { }

	internal override void OnEnable() { }

	internal object ReadAssetReference(StyleValueHandle handle) { }

	internal Color ReadColor(StyleValueHandle handle) { }

	internal Dimension ReadDimension(StyleValueHandle handle) { }

	internal string ReadEnum(StyleValueHandle handle) { }

	internal float ReadFloat(StyleValueHandle handle) { }

	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	internal string ReadFunctionName(StyleValueHandle handle) { }

	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	internal string ReadResourcePath(StyleValueHandle handle) { }

	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	internal string ReadString(StyleValueHandle handle) { }

	internal string ReadVariable(StyleValueHandle handle) { }

	internal void set_complexSelectors(StyleComplexSelector[] value) { }

	public void set_contentHash(int value) { }

	internal void set_importedWithErrors(bool value) { }

	internal void set_importedWithWarnings(bool value) { }

	internal void set_isDefaultStyleSheet(bool value) { }

	internal void set_rules(StyleRule[] value) { }

	private void SetupReferences() { }

	private bool TryCheckAccess(T[] list, StyleValueType type, StyleValueHandle handle, out T value) { }

	internal bool TryReadAssetReference(StyleValueHandle handle, out object value) { }

	internal bool TryReadColor(StyleValueHandle handle, out Color value) { }

	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) { }

	internal bool TryReadEnum(StyleValueHandle handle, out string value) { }

	internal bool TryReadFloat(StyleValueHandle handle, out float value) { }

	internal bool TryReadResourcePath(StyleValueHandle handle, out string value) { }

	internal bool TryReadString(StyleValueHandle handle, out string value) { }

	internal bool TryReadVariable(StyleValueHandle handle, out string value) { }

}

