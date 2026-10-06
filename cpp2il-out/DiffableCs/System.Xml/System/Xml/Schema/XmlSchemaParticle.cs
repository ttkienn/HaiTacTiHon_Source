namespace System.Xml.Schema;

public abstract class XmlSchemaParticle : XmlSchemaAnnotated
{
	private class EmptyParticle : XmlSchemaParticle
	{

		internal virtual bool IsEmpty
		{
			internal get { } //Length: 3
		}

		public EmptyParticle() { }

		internal virtual bool get_IsEmpty() { }

	}

	[Flags]
	private enum Occurs
	{
		None = 0,
		Min = 1,
		Max = 2,
	}

	internal static readonly XmlSchemaParticle Empty; //Field offset: 0x0
	private decimal minOccurs; //Field offset: 0x50
	private decimal maxOccurs; //Field offset: 0x60
	private Occurs flags; //Field offset: 0x70

	internal override bool IsEmpty
	{
		internal get { } //Length: 127
	}

	[XmlIgnore]
	public decimal MaxOccurs
	{
		 get { } //Length: 11
		 set { } //Length: 418
	}

	[XmlAttribute("maxOccurs")]
	public string MaxOccursString
	{
		 get { } //Length: 276
		 set { } //Length: 565
	}

	[XmlIgnore]
	public decimal MinOccurs
	{
		 get { } //Length: 11
		 set { } //Length: 325
	}

	[XmlAttribute("minOccurs")]
	public string MinOccursString
	{
		 get { } //Length: 110
		 set { } //Length: 367
	}

	internal override string NameString
	{
		internal get { } //Length: 54
	}

	private static XmlSchemaParticle() { }

	protected XmlSchemaParticle() { }

	internal override bool get_IsEmpty() { }

	public decimal get_MaxOccurs() { }

	public string get_MaxOccursString() { }

	public decimal get_MinOccurs() { }

	public string get_MinOccursString() { }

	internal override string get_NameString() { }

	internal XmlQualifiedName GetQualifiedName() { }

	public void set_MaxOccurs(decimal value) { }

	public void set_MaxOccursString(string value) { }

	public void set_MinOccurs(decimal value) { }

	public void set_MinOccursString(string value) { }

}

