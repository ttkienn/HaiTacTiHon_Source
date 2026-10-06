namespace System.Runtime.Remoting.Metadata;

[ComVisible(True)]
public class SoapAttribute : Attribute
{
	private bool _useAttribute; //Field offset: 0x10
	protected string ProtXmlNamespace; //Field offset: 0x18
	protected object ReflectInfo; //Field offset: 0x20

	public override bool UseAttribute
	{
		 get { } //Length: 5
	}

	public override string XmlNamespace
	{
		 get { } //Length: 5
	}

	public SoapAttribute() { }

	public override bool get_UseAttribute() { }

	public override string get_XmlNamespace() { }

	internal override void SetReflectionObject(object reflectionObject) { }

}

