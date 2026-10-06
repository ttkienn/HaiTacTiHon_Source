namespace System.Runtime.Serialization;

[ComVisible(True)]
public class ObjectManager
{
	private DeserializationEventHandler m_onDeserializationHandler; //Field offset: 0x10
	private SerializationEventHandler m_onDeserializedHandler; //Field offset: 0x18
	internal ObjectHolder[] m_objects; //Field offset: 0x20
	internal object m_topObject; //Field offset: 0x28
	internal ObjectHolderList m_specialFixupObjects; //Field offset: 0x30
	internal long m_fixupCount; //Field offset: 0x38
	internal ISurrogateSelector m_selector; //Field offset: 0x40
	internal StreamingContext m_context; //Field offset: 0x48

	internal ObjectHolderList SpecialFixupObjects
	{
		internal get { } //Length: 173
	}

	internal object TopObject
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	private void AddObjectHolder(ObjectHolder holder) { }

	internal override void AddOnDeserialization(DeserializationEventHandler handler) { }

	internal override void AddOnDeserialized(object obj) { }

	private bool CanCallGetType(object obj) { }

	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	public override void DoFixups() { }

	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	internal ObjectHolder FindObjectHolder(long objectID) { }

	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	private void FixupSpecialObject(ObjectHolder holder) { }

	internal ObjectHolderList get_SpecialFixupObjects() { }

	internal object get_TopObject() { }

	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	public override object GetObject(long objectID) { }

	public override void RaiseDeserializationEvent() { }

	internal override void RaiseOnDeserializedEvent(object obj) { }

	public void RaiseOnDeserializingEvent(object obj) { }

	public override void RecordArrayElementFixup(long arrayToBeFixed, Int32[] indices, long objectRequired) { }

	public override void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	public override void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, Int32[] arrayIndex) { }

	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	private bool ResolveObjectReference(ObjectHolder holder) { }

	internal void set_TopObject(object value) { }

}

