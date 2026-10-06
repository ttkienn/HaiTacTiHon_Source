namespace System.Xml.Xsl.Runtime;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public struct StringConcat
{
	private string s1; //Field offset: 0x0
	private string s2; //Field offset: 0x8
	private string s3; //Field offset: 0x10
	private string s4; //Field offset: 0x18
	private string delimiter; //Field offset: 0x20
	private List<String> strList; //Field offset: 0x28
	private int idxStr; //Field offset: 0x30

	internal int Count
	{
		internal get { } //Length: 4
	}

	public void Clear() { }

	internal void ConcatNoDelimiter(string s) { }

	internal int get_Count() { }

	public string GetResult() { }

}

