namespace System.Net;

internal class ResponseDescription
{
	internal bool Multiline; //Field offset: 0x10
	internal int Status; //Field offset: 0x14
	internal string StatusDescription; //Field offset: 0x18
	internal StringBuilder StatusBuffer; //Field offset: 0x20
	internal string StatusCodeString; //Field offset: 0x28

	internal bool InvalidStatusCode
	{
		internal get { } //Length: 20
	}

	internal bool PermanentFailure
	{
		internal get { } //Length: 23
	}

	internal bool PositiveCompletion
	{
		internal get { } //Length: 23
	}

	internal bool PositiveIntermediate
	{
		internal get { } //Length: 20
	}

	internal bool TransientFailure
	{
		internal get { } //Length: 23
	}

	public ResponseDescription() { }

	internal bool get_InvalidStatusCode() { }

	internal bool get_PermanentFailure() { }

	internal bool get_PositiveCompletion() { }

	internal bool get_PositiveIntermediate() { }

	internal bool get_TransientFailure() { }

}

