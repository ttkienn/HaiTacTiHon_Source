namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectWriter
{
	private Queue m_objectQueue; //Field offset: 0x10
	private ObjectIDGenerator m_idGenerator; //Field offset: 0x18
	private int m_currentId; //Field offset: 0x20
	private ISurrogateSelector m_surrogates; //Field offset: 0x28
	private StreamingContext m_context; //Field offset: 0x30
	private __BinaryWriter serWriter; //Field offset: 0x40
	private SerializationObjectManager m_objectManager; //Field offset: 0x48
	private long topId; //Field offset: 0x50
	private string topName; //Field offset: 0x58
	private Header[] headers; //Field offset: 0x60
	private InternalFE formatterEnums; //Field offset: 0x68
	private SerializationBinder m_binder; //Field offset: 0x70
	private SerObjectInfoInit serObjectInfoInit; //Field offset: 0x78
	private IFormatterConverter m_formatterConverter; //Field offset: 0x80
	internal Object[] crossAppDomainArray; //Field offset: 0x88
	private object previousObj; //Field offset: 0x90
	private long previousId; //Field offset: 0x98
	private Type previousType; //Field offset: 0xA0
	private InternalPrimitiveTypeE previousCode; //Field offset: 0xA8
	private Hashtable assemblyToIdTable; //Field offset: 0xB0
	private SerStack niPool; //Field offset: 0xB8

	internal SerializationObjectManager ObjectManager
	{
		internal get { } //Length: 5
	}

	internal ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	internal SerializationObjectManager get_ObjectManager() { }

	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	private NameInfo GetNameInfo() { }

	private object GetNext(out long objID) { }

	private Type GetType(object obj) { }

	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	private NameInfo MemberToNameInfo(string name) { }

	private void PutNameInfo(NameInfo nameInfo) { }

	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	internal InternalPrimitiveTypeE ToCode(Type type) { }

	private NameInfo TypeToNameInfo(Type type) { }

	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, String[] memberNames, Type[] memberTypes, Object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, Int32[] maxA, Array array, NameInfo arrayElemNameTypeInfo, Int32[] lowerBoundA) { }

	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

}

