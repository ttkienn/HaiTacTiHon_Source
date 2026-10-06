namespace UnityEngine.Purchasing;

public class LocalizedProductDescription
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static MatchEvaluator <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <DecodeNonLatinCharacters>b__11_0(Match m) { }

	}

	public TranslationLocale googleLocale; //Field offset: 0x10
	[SerializeField]
	private string title; //Field offset: 0x18
	[SerializeField]
	private string description; //Field offset: 0x20

	public string Description
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public string Title
	{
		 get { } //Length: 11
		 set { } //Length: 43
	}

	public LocalizedProductDescription() { }

	public LocalizedProductDescription Clone() { }

	private static string DecodeNonLatinCharacters(string s) { }

	private static string EncodeNonLatinCharacters(string s) { }

	public string get_Description() { }

	public string get_Title() { }

	public void set_Description(string value) { }

	public void set_Title(string value) { }

}

