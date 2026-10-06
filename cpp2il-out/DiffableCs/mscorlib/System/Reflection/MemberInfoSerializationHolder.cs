namespace System.Reflection;

internal class MemberInfoSerializationHolder : ISerializable, IObjectReference
{
	private string m_memberName; //Field offset: 0x10
	private RuntimeType m_reflectedType; //Field offset: 0x18
	private string m_signature; //Field offset: 0x20
	private string m_signature2; //Field offset: 0x28
	private MemberTypes m_memberType; //Field offset: 0x30
	private SerializationInfo m_info; //Field offset: 0x38

	internal MemberInfoSerializationHolder(SerializationInfo info, StreamingContext context) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override object GetRealObject(StreamingContext context) { }

	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

}

