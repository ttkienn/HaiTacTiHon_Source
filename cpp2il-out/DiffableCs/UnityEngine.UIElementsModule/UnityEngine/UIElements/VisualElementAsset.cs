namespace UnityEngine.UIElements;

internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver
{
	[SerializeField]
	private string m_Name; //Field offset: 0x30
	[SerializeField]
	private int m_RuleIndex; //Field offset: 0x38
	[SerializeField]
	private string m_Text; //Field offset: 0x40
	[SerializeField]
	private PickingMode m_PickingMode; //Field offset: 0x48
	[SerializeField]
	private String[] m_Classes; //Field offset: 0x50
	[SerializeField]
	private List<String> m_StylesheetPaths; //Field offset: 0x58
	[SerializeField]
	private List<StyleSheet> m_Stylesheets; //Field offset: 0x60
	[SerializeField]
	private bool m_SkipClone; //Field offset: 0x68

	public String[] classes
	{
		 get { } //Length: 7
	}

	public bool hasStylesheetPaths
	{
		 get { } //Length: 9
	}

	public bool hasStylesheets
	{
		 get { } //Length: 9
	}

	public int ruleIndex
	{
		 get { } //Length: 6
	}

	internal bool skipClone
	{
		internal get { } //Length: 5
	}

	public List<String> stylesheetPaths
	{
		 get { } //Length: 123
	}

	public List<StyleSheet> stylesheets
	{
		 get { } //Length: 123
	}

	public String[] get_classes() { }

	public bool get_hasStylesheetPaths() { }

	public bool get_hasStylesheets() { }

	public int get_ruleIndex() { }

	internal bool get_skipClone() { }

	public List<String> get_stylesheetPaths() { }

	public List<StyleSheet> get_stylesheets() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

