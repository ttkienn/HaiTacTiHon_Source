namespace System.Security.Util;

internal sealed class TokenizerStream
{
	private int m_countTokens; //Field offset: 0x10
	private TokenizerShortBlock m_headTokens; //Field offset: 0x18
	private TokenizerShortBlock m_lastTokens; //Field offset: 0x20
	private TokenizerShortBlock m_currentTokens; //Field offset: 0x28
	private int m_indexTokens; //Field offset: 0x30
	private TokenizerStringBlock m_headStrings; //Field offset: 0x38
	private TokenizerStringBlock m_currentStrings; //Field offset: 0x40
	private int m_indexStrings; //Field offset: 0x48

	internal TokenizerStream() { }

	internal void AddString(string str) { }

	internal void AddToken(short token) { }

	internal short GetNextFullToken() { }

	internal string GetNextString() { }

	internal short GetNextToken() { }

	internal int GetTokenCount() { }

	internal void GoToPosition(int position) { }

	internal void Reset() { }

	internal void TagLastToken(short tag) { }

	internal void ThrowAwayNextString() { }

}

