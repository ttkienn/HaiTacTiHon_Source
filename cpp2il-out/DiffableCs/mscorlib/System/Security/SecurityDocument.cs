namespace System.Security;

internal sealed class SecurityDocument
{
	internal Byte[] m_data; //Field offset: 0x10

	public SecurityDocument(int numData) { }

	public void AddString(string str, ref int position) { }

	public void AddToken(byte b, ref int position) { }

	public void AppendString(string str, ref int position) { }

	public static int EncodedStringSize(string str) { }

	public SecurityElement GetElement(int position, bool bCreate) { }

	public SecurityElement GetRootElement() { }

	public string GetString(ref int position, bool bCreate) { }

	public void GuaranteeSize(int size) { }

	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }

}

