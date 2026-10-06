namespace System;

public class UriBuilder
{
	private bool _changed; //Field offset: 0x10
	private string _fragment; //Field offset: 0x18
	private string _host; //Field offset: 0x20
	private string _password; //Field offset: 0x28
	private string _path; //Field offset: 0x30
	private int _port; //Field offset: 0x38
	private string _query; //Field offset: 0x40
	private string _scheme; //Field offset: 0x48
	private string _schemeDelimiter; //Field offset: 0x50
	private Uri _uri; //Field offset: 0x58
	private string _username; //Field offset: 0x60

	public string Path
	{
		 set { } //Length: 171
	}

	public Uri Uri
	{
		 get { } //Length: 162
	}

	public UriBuilder(Uri uri) { }

	public virtual bool Equals(object rparam) { }

	public Uri get_Uri() { }

	public virtual int GetHashCode() { }

	private void Init(Uri uri) { }

	public void set_Path(string value) { }

	private void SetFieldsFromUri(Uri uri) { }

	public virtual string ToString() { }

}

