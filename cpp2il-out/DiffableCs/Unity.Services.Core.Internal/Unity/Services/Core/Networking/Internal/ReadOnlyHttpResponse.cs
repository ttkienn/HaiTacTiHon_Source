namespace Unity.Services.Core.Networking.Internal;

internal struct ReadOnlyHttpResponse
{
	private HttpResponse m_Response; //Field offset: 0x0

	public Byte[] Data
	{
		 get { } //Length: 26
	}

	public string ErrorMessage
	{
		 get { } //Length: 26
	}

	public IReadOnlyDictionary<String, String> Headers
	{
		 get { } //Length: 26
	}

	public bool IsHttpError
	{
		 get { } //Length: 26
	}

	public bool IsNetworkError
	{
		 get { } //Length: 26
	}

	public ReadOnlyHttpRequest Request
	{
		 get { } //Length: 26
	}

	public long StatusCode
	{
		 get { } //Length: 26
	}

	public ReadOnlyHttpResponse(HttpResponse response) { }

	public Byte[] get_Data() { }

	public string get_ErrorMessage() { }

	public IReadOnlyDictionary<String, String> get_Headers() { }

	public bool get_IsHttpError() { }

	public bool get_IsNetworkError() { }

	public ReadOnlyHttpRequest get_Request() { }

	public long get_StatusCode() { }

}

