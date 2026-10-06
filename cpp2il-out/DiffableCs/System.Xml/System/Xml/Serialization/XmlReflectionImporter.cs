namespace System.Xml.Serialization;

public class XmlReflectionImporter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<XmlReflectionMember> <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }

	}

	private static readonly string errSimple; //Field offset: 0x0
	private static readonly string errSimple2; //Field offset: 0x8
	private string initialDefaultNamespace; //Field offset: 0x10
	private XmlAttributeOverrides attributeOverrides; //Field offset: 0x18
	private ArrayList includedTypes; //Field offset: 0x20
	private ReflectionHelper helper; //Field offset: 0x28
	private int arrayChoiceCount; //Field offset: 0x30
	private ArrayList relatedMaps; //Field offset: 0x38
	private bool allowPrivateTypes; //Field offset: 0x40

	private static XmlReflectionImporter() { }

	public XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	private bool CanBeNull(TypeData type) { }

	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false) { }

	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false) { }

	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	public XmlTypeMapping ImportTypeMapping(Type type) { }

	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	public void IncludeType(Type type) { }

	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

}

