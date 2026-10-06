namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal class StyleSyntaxTokenizer
{
	private List<StyleSyntaxToken> m_Tokens; //Field offset: 0x10
	private int m_CurrentTokenIndex; //Field offset: 0x18

	public StyleSyntaxToken current
	{
		 get { } //Length: 188
	}

	public StyleSyntaxTokenizer() { }

	public StyleSyntaxToken get_current() { }

	private static int GlobCharacter(string s, int index, char c) { }

	private static bool IsNextCharacter(string s, int index, char c) { }

	private static bool IsNextLetterOrDash(string s, int index) { }

	private static bool IsNextNumber(string s, int index) { }

	public StyleSyntaxToken MoveNext() { }

	public StyleSyntaxToken PeekNext() { }

	public void Tokenize(string syntax) { }

}

