namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectReader
{
	public sealed class TopLevelAssemblyTypeResolver
	{
		private Assembly m_topLevelAssembly; //Field offset: 0x10

		public TopLevelAssemblyTypeResolver(Assembly topLevelAssembly) { }

		public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }

	}

	public class TypeNAssembly
	{
		public Type type; //Field offset: 0x10
		public string assemblyName; //Field offset: 0x18

		public TypeNAssembly() { }

	}

	internal Stream m_stream; //Field offset: 0x10
	internal ISurrogateSelector m_surrogates; //Field offset: 0x18
	internal StreamingContext m_context; //Field offset: 0x20
	internal ObjectManager m_objectManager; //Field offset: 0x30
	internal InternalFE formatterEnums; //Field offset: 0x38
	internal SerializationBinder m_binder; //Field offset: 0x40
	internal long topId; //Field offset: 0x48
	internal bool bSimpleAssembly; //Field offset: 0x50
	internal object handlerObject; //Field offset: 0x58
	internal object m_topObject; //Field offset: 0x60
	internal Header[] headers; //Field offset: 0x68
	internal HeaderHandler handler; //Field offset: 0x70
	internal SerObjectInfoInit serObjectInfoInit; //Field offset: 0x78
	internal IFormatterConverter m_formatterConverter; //Field offset: 0x80
	internal SerStack stack; //Field offset: 0x88
	private SerStack valueFixupStack; //Field offset: 0x90
	internal Object[] crossAppDomainArray; //Field offset: 0x98
	private bool bFullDeserialization; //Field offset: 0xA0
	private bool bOldFormatDetected; //Field offset: 0xA1
	private IntSizedArray valTypeObjectIdTable; //Field offset: 0xA8
	private NameCache typeCache; //Field offset: 0xB0
	private string previousAssemblyString; //Field offset: 0xB8
	private string previousName; //Field offset: 0xC0
	private Type previousType; //Field offset: 0xC8

	internal object TopObject
	{
		internal get { } //Length: 5
		internal set { } //Length: 67
	}

	private SerStack ValueFixupStack
	{
		private get { } //Length: 137
	}

	internal ObjectReader(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	internal Type Bind(string assemblyString, string typeString) { }

	private void CheckSerializable(Type t) { }

	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }

	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, String[] memberNames, Type[] memberTypes) { }

	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	internal object CrossAppDomainArray(int index) { }

	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	internal Type FastBindToType(string assemblyName, string typeName) { }

	internal object get_TopObject() { }

	private SerStack get_ValueFixupStack() { }

	internal long GetId(long objectId) { }

	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	private bool HasSurrogate(Type t) { }

	private void InitFullDeserialization() { }

	private void NextRectangleMap(ParseRecord pr) { }

	internal void Parse(ParseRecord pr) { }

	private void ParseArray(ParseRecord pr) { }

	private void ParseArrayMember(ParseRecord pr) { }

	private void ParseArrayMemberEnd(ParseRecord pr) { }

	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	private void ParseMember(ParseRecord pr) { }

	private void ParseMemberEnd(ParseRecord pr) { }

	private void ParseObject(ParseRecord pr) { }

	private void ParseObjectEnd(ParseRecord pr) { }

	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	internal void set_TopObject(object value) { }

}

