namespace UnityEngine;

public class WWWForm
{
	private static Byte[] dDash; //Field offset: 0x0
	private static Byte[] crlf; //Field offset: 0x8
	private static Byte[] contentTypeHeader; //Field offset: 0x10
	private static Byte[] dispositionHeader; //Field offset: 0x18
	private static Byte[] endQuote; //Field offset: 0x20
	private static Byte[] fileNameField; //Field offset: 0x28
	private static Byte[] ampersand; //Field offset: 0x30
	private static Byte[] equal; //Field offset: 0x38

	internal static Encoding DefaultEncoding
	{
		internal get { } //Length: 9
	}

	private static WWWForm() { }

	internal static Encoding get_DefaultEncoding() { }

}

