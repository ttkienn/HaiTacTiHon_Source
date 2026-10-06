namespace System.Xml.Schema;

internal class ContentValidator
{
	public static readonly ContentValidator Empty; //Field offset: 0x0
	public static readonly ContentValidator TextOnly; //Field offset: 0x8
	public static readonly ContentValidator Mixed; //Field offset: 0x10
	public static readonly ContentValidator Any; //Field offset: 0x18
	private XmlSchemaContentType contentType; //Field offset: 0x10
	private bool isOpen; //Field offset: 0x14
	private bool isEmptiable; //Field offset: 0x15

	public XmlSchemaContentType ContentType
	{
		 get { } //Length: 191
	}

	public override bool IsEmptiable
	{
		 get { } //Length: 5
	}

	public bool IsOpen
	{
		 get { } //Length: 20
		 set { } //Length: 4
	}

	public bool PreserveWhitespace
	{
		 get { } //Length: 17
	}

	private static ContentValidator() { }

	public ContentValidator(XmlSchemaContentType contentType) { }

	protected ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	public override bool CompleteValidation(ValidationState context) { }

	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	public XmlSchemaContentType get_ContentType() { }

	public override bool get_IsEmptiable() { }

	public bool get_IsOpen() { }

	public bool get_PreserveWhitespace() { }

	public override void InitValidation(ValidationState context) { }

	public void set_IsOpen(bool value) { }

	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

