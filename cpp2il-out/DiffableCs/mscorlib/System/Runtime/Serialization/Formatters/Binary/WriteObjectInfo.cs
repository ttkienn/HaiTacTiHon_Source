namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class WriteObjectInfo
{
	internal int objectInfoId; //Field offset: 0x10
	internal object obj; //Field offset: 0x18
	internal Type objectType; //Field offset: 0x20
	internal bool isSi; //Field offset: 0x28
	internal bool isNamed; //Field offset: 0x29
	internal bool isTyped; //Field offset: 0x2A
	internal bool isArray; //Field offset: 0x2B
	internal SerializationInfo si; //Field offset: 0x30
	internal SerObjectInfoCache cache; //Field offset: 0x38
	internal Object[] memberData; //Field offset: 0x40
	internal ISerializationSurrogate serializationSurrogate; //Field offset: 0x48
	internal StreamingContext context; //Field offset: 0x50
	internal SerObjectInfoInit serObjectInfoInit; //Field offset: 0x60
	internal long objectId; //Field offset: 0x68
	internal long assemId; //Field offset: 0x70
	private string binderTypeName; //Field offset: 0x78
	private string binderAssemblyString; //Field offset: 0x80

	internal WriteObjectInfo() { }

	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	internal string GetAssemblyString() { }

	internal void GetMemberInfo(out String[] outMemberNames, out Type[] outMemberTypes, out Object[] outMemberData) { }

	internal Type GetMemberType(MemberInfo objMember) { }

	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	internal string GetTypeFullName() { }

	private void InitMemberInfo() { }

	private void InitNoMembers() { }

	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	private void InitSiWrite() { }

	private void InternalInit() { }

	private void InvokeSerializationBinder(SerializationBinder binder) { }

	internal void ObjectEnd() { }

	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }

	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

}

