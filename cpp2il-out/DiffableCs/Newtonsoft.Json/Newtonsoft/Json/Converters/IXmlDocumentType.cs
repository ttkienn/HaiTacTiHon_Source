namespace Newtonsoft.Json.Converters;

[NullableContext(2)]
internal interface IXmlDocumentType : IXmlNode
{

	public string InternalSubset
	{
		 get { } //Length: 0
	}

	[Nullable(1)]
	public string Name
	{
		[NullableContext(1)]
		 get { } //Length: 0
	}

	public string Public
	{
		 get { } //Length: 0
	}

	public string System
	{
		 get { } //Length: 0
	}

	public string get_InternalSubset() { }

	[NullableContext(1)]
	public string get_Name() { }

	public string get_Public() { }

	public string get_System() { }

}

