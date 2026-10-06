namespace Unity.Services.Core.Networking.Internal;

internal struct ReadOnlyHttpRequest
{
	private HttpRequest m_Request; //Field offset: 0x0

	public Byte[] Body
	{
		 get { } //Length: 26
	}

	public IReadOnlyDictionary<String, String> Headers
	{
		 get { } //Length: 26
	}

	public string Method
	{
		 get { } //Length: 26
	}

	public string Url
	{
		 get { } //Length: 26
	}

	public ReadOnlyHttpRequest(HttpRequest request) { }

	public Byte[] get_Body() { }

	public IReadOnlyDictionary<String, String> get_Headers() { }

	public string get_Method() { }

	public string get_Url() { }

}

