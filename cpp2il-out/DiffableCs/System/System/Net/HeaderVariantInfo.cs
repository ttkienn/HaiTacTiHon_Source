namespace System.Net;

internal struct HeaderVariantInfo
{
	private string m_name; //Field offset: 0x0
	private CookieVariant m_variant; //Field offset: 0x8

	internal string Name
	{
		internal get { } //Length: 4
	}

	internal CookieVariant Variant
	{
		internal get { } //Length: 4
	}

	internal HeaderVariantInfo(string name, CookieVariant variant) { }

	internal string get_Name() { }

	internal CookieVariant get_Variant() { }

}

