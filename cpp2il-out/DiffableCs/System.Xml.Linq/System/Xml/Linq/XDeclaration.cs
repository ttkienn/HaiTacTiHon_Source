namespace System.Xml.Linq;

public class XDeclaration
{
	private string _version; //Field offset: 0x10
	private string _encoding; //Field offset: 0x18
	private string _standalone; //Field offset: 0x20

	public string Encoding
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public string Standalone
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public string Version
	{
		 get { } //Length: 5
	}

	public XDeclaration(string version, string encoding, string standalone) { }

	public XDeclaration(XDeclaration other) { }

	public string get_Encoding() { }

	public string get_Standalone() { }

	public string get_Version() { }

	public void set_Encoding(string value) { }

	public void set_Standalone(string value) { }

	public virtual string ToString() { }

}

