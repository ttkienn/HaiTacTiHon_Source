namespace System.Net;

[DefaultMember("Item")]
internal class HeaderInfoTable
{
	private static Hashtable HeaderHashTable; //Field offset: 0x0
	private static HeaderInfo UnknownHeaderInfo; //Field offset: 0x8
	private static HeaderParser SingleParser; //Field offset: 0x10
	private static HeaderParser MultiParser; //Field offset: 0x18

	internal HeaderInfo Item
	{
		internal get { } //Length: 233
	}

	private static HeaderInfoTable() { }

	public HeaderInfoTable() { }

	internal HeaderInfo get_Item(string name) { }

	private static String[] ParseMultiValue(string value) { }

	private static String[] ParseSingleValue(string value) { }

}

