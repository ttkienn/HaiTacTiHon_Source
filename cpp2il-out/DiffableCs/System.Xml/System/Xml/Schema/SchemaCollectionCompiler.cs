namespace System.Xml.Schema;

internal sealed class SchemaCollectionCompiler : BaseProcessor
{
	private bool compileContentModel; //Field offset: 0x40
	private XmlSchemaObjectTable examplars; //Field offset: 0x48
	private Stack complexTypeStack; //Field offset: 0x50
	private XmlSchema schema; //Field offset: 0x58

	public SchemaCollectionCompiler(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out decimal minOccurs, out decimal maxOccurs) { }

	private void CalculateSequenceRange(XmlSchemaSequence sequence, out decimal minOccurs, out decimal maxOccurs) { }

	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	private void Cleanup() { }

	internal static void Cleanup(XmlSchema schema) { }

	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	private static void CleanupElement(XmlSchemaElement element) { }

	private static void CleanupGroup(XmlSchemaGroup group) { }

	private static void CleanupParticle(XmlSchemaParticle particle) { }

	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	private void Compile() { }

	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	private void CompileAttribute(XmlSchemaAttribute xa) { }

	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	private void CompileElement(XmlSchemaElement xe) { }

	private void CompileGroup(XmlSchemaGroup group) { }

	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	private bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs) { }

	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private void Output(SchemaInfo schemaInfo) { }

	private void Prepare() { }

	private void PushComplexType(XmlSchemaComplexType complexType) { }

}

