namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XCommentWrapper : XObjectWrapper
{

	public virtual IXmlNode ParentNode
	{
		 get { } //Length: 162
	}

	[Nullable(1)]
	private XComment Text
	{
		[NullableContext(1)]
		private get { } //Length: 107
	}

	public virtual string Value
	{
		 get { } //Length: 117
		 set { } //Length: 189
	}

	[NullableContext(1)]
	public XCommentWrapper(XComment text) { }

	public virtual IXmlNode get_ParentNode() { }

	[NullableContext(1)]
	private XComment get_Text() { }

	public virtual string get_Value() { }

	public virtual void set_Value(string value) { }

}

