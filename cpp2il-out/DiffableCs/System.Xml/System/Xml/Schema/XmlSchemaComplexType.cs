namespace System.Xml.Schema;

public class XmlSchemaComplexType : XmlSchemaType
{
	private static XmlSchemaComplexType anyTypeLax; //Field offset: 0x0
	private static XmlSchemaComplexType anyTypeSkip; //Field offset: 0x8
	private static XmlSchemaComplexType untypedAnyType; //Field offset: 0x10
	private XmlSchemaDerivationMethod block; //Field offset: 0x98
	private XmlSchemaContentModel contentModel; //Field offset: 0xA0
	private XmlSchemaParticle particle; //Field offset: 0xA8
	private XmlSchemaObjectCollection attributes; //Field offset: 0xB0
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0xB8
	private XmlSchemaParticle contentTypeParticle; //Field offset: 0xC0
	private XmlSchemaDerivationMethod blockResolved; //Field offset: 0xC8
	private XmlSchemaObjectTable localElements; //Field offset: 0xD0
	private XmlSchemaObjectTable attributeUses; //Field offset: 0xD8
	private XmlSchemaAnyAttribute attributeWildcard; //Field offset: 0xE0
	private byte pvFlags; //Field offset: 0xE8

	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType
	{
		internal get { } //Length: 78
	}

	internal static ContentValidator AnyTypeContentValidator
	{
		internal get { } //Length: 107
	}

	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes
	{
		 get { } //Length: 117
	}

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses
	{
		 get { } //Length: 117
	}

	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard
	{
		 get { } //Length: 8
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("block")]
	public XmlSchemaDerivationMethod Block
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved
	{
		 get { } //Length: 7
	}

	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	public XmlSchemaContentModel ContentModel
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[XmlIgnore]
	public XmlSchemaContentType ContentType
	{
		 get { } //Length: 7
	}

	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle
	{
		 get { } //Length: 8
	}

	internal bool HasWildCard
	{
		internal set { } //Length: 39
	}

	[DefaultValue(False)]
	[XmlAttribute("abstract")]
	public bool IsAbstract
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	[DefaultValue(False)]
	[XmlAttribute("mixed")]
	public virtual bool IsMixed
	{
		 get { } //Length: 11
		 set { } //Length: 39
	}

	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements
	{
		internal get { } //Length: 117
	}

	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType
	{
		internal get { } //Length: 79
	}

	private static XmlSchemaComplexType() { }

	public XmlSchemaComplexType() { }

	private void ClearCompiledState() { }

	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	internal virtual XmlSchemaObject Clone() { }

	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	internal bool ContainsIdAttribute(bool findAll) { }

	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	internal static XmlSchemaComplexType get_AnyType() { }

	internal static ContentValidator get_AnyTypeContentValidator() { }

	public XmlSchemaObjectCollection get_Attributes() { }

	public XmlSchemaObjectTable get_AttributeUses() { }

	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	public XmlSchemaDerivationMethod get_Block() { }

	public XmlSchemaDerivationMethod get_BlockResolved() { }

	public XmlSchemaContentModel get_ContentModel() { }

	public XmlSchemaContentType get_ContentType() { }

	public XmlSchemaParticle get_ContentTypeParticle() { }

	public bool get_IsAbstract() { }

	public virtual bool get_IsMixed() { }

	internal XmlSchemaObjectTable get_LocalElements() { }

	public XmlSchemaParticle get_Particle() { }

	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	public void set_Block(XmlSchemaDerivationMethod value) { }

	public void set_ContentModel(XmlSchemaContentModel value) { }

	internal void set_HasWildCard(bool value) { }

	public void set_IsAbstract(bool value) { }

	public virtual void set_IsMixed(bool value) { }

	public void set_Particle(XmlSchemaParticle value) { }

	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

}

