namespace UnityEngine.TextCore.Text;

public class UnicodeLineBreakingRules
{
	[SerializeField]
	private TextAsset m_UnicodeLineBreakingRules; //Field offset: 0x10
	[SerializeField]
	private TextAsset m_LeadingCharacters; //Field offset: 0x18
	[SerializeField]
	private TextAsset m_FollowingCharacters; //Field offset: 0x20
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; //Field offset: 0x28
	private HashSet<UInt32> m_LeadingCharactersLookup; //Field offset: 0x30
	private HashSet<UInt32> m_FollowingCharactersLookup; //Field offset: 0x38

	public TextAsset followingCharacters
	{
		 get { } //Length: 5
	}

	internal HashSet<UInt32> followingCharactersLookup
	{
		internal get { } //Length: 52
	}

	public TextAsset leadingCharacters
	{
		 get { } //Length: 5
	}

	internal HashSet<UInt32> leadingCharactersLookup
	{
		internal get { } //Length: 52
	}

	public bool useModernHangulLineBreakingRules
	{
		 get { } //Length: 5
	}

	public UnicodeLineBreakingRules() { }

	public TextAsset get_followingCharacters() { }

	internal HashSet<UInt32> get_followingCharactersLookup() { }

	public TextAsset get_leadingCharacters() { }

	internal HashSet<UInt32> get_leadingCharactersLookup() { }

	public bool get_useModernHangulLineBreakingRules() { }

	private static HashSet<UInt32> GetCharacters(TextAsset file) { }

	internal void LoadLineBreakingRules() { }

	internal void LoadLineBreakingRules(TextAsset leadingRules, TextAsset followingRules) { }

}

