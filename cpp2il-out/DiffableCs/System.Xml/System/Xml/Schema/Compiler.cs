namespace System.Xml.Schema;

internal sealed class Compiler : BaseProcessor
{
	private string restrictionErrorMsg; //Field offset: 0x40
	private XmlSchemaObjectTable attributes; //Field offset: 0x48
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x50
	private XmlSchemaObjectTable elements; //Field offset: 0x58
	private XmlSchemaObjectTable schemaTypes; //Field offset: 0x60
	private XmlSchemaObjectTable groups; //Field offset: 0x68
	private XmlSchemaObjectTable notations; //Field offset: 0x70
	private XmlSchemaObjectTable examplars; //Field offset: 0x78
	private XmlSchemaObjectTable identityConstraints; //Field offset: 0x80
	private Stack complexTypeStack; //Field offset: 0x88
	private Hashtable schemasToCompile; //Field offset: 0x90
	private Hashtable importedSchemas; //Field offset: 0x98
	private XmlSchema schemaForSchema; //Field offset: 0xA0

	public Compiler(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out decimal minOccurs, out decimal maxOccurs) { }

	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	private void CleanupElement(XmlSchemaElement element) { }

	private void CleanupGroup(XmlSchemaGroup group) { }

	private void CleanupParticle(XmlSchemaParticle particle) { }

	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	internal bool Compile() { }

	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	private void CompileAttribute(XmlSchemaAttribute xa) { }

	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	private void CompileElement(XmlSchemaElement xe) { }

	private void CompileGroup(XmlSchemaGroup group) { }

	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	private void CompileParticleElements(XmlSchemaParticle particle) { }

	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	private bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs) { }

	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	private void Output(SchemaInfo schemaInfo) { }

	internal void Prepare(XmlSchema schema, bool cleanup) { }

	private void ProcessSubstitutionGroups() { }

	private void PushComplexType(XmlSchemaComplexType complexType) { }

	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	private void UpdateSForSSimpleTypes() { }

}

