namespace UnityEngine.UI;

public class AnimationTriggers
{
	private const string kDefaultNormalAnimName = "Normal"; //Field offset: 0x0
	private const string kDefaultHighlightedAnimName = "Highlighted"; //Field offset: 0x0
	private const string kDefaultPressedAnimName = "Pressed"; //Field offset: 0x0
	private const string kDefaultSelectedAnimName = "Selected"; //Field offset: 0x0
	private const string kDefaultDisabledAnimName = "Disabled"; //Field offset: 0x0
	[FormerlySerializedAs("normalTrigger")]
	[SerializeField]
	private string m_NormalTrigger; //Field offset: 0x10
	[FormerlySerializedAs("highlightedTrigger")]
	[SerializeField]
	private string m_HighlightedTrigger; //Field offset: 0x18
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	private string m_PressedTrigger; //Field offset: 0x20
	[FormerlySerializedAs("m_HighlightedTrigger")]
	[SerializeField]
	private string m_SelectedTrigger; //Field offset: 0x28
	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	private string m_DisabledTrigger; //Field offset: 0x30

	public string disabledTrigger
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public string highlightedTrigger
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public string normalTrigger
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public string pressedTrigger
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public string selectedTrigger
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public AnimationTriggers() { }

	public string get_disabledTrigger() { }

	public string get_highlightedTrigger() { }

	public string get_normalTrigger() { }

	public string get_pressedTrigger() { }

	public string get_selectedTrigger() { }

	public void set_disabledTrigger(string value) { }

	public void set_highlightedTrigger(string value) { }

	public void set_normalTrigger(string value) { }

	public void set_pressedTrigger(string value) { }

	public void set_selectedTrigger(string value) { }

}

