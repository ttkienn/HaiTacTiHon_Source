namespace System.Net;

internal class WebRequestPrefixElement
{
	public string Prefix; //Field offset: 0x10
	internal IWebRequestCreate creator; //Field offset: 0x18
	internal Type creatorType; //Field offset: 0x20

	public IWebRequestCreate Creator
	{
		 get { } //Length: 496
		 set { } //Length: 13
	}

	public WebRequestPrefixElement(string P, IWebRequestCreate C) { }

	public IWebRequestCreate get_Creator() { }

	public void set_Creator(IWebRequestCreate value) { }

}

