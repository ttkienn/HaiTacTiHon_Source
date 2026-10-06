namespace System.Runtime.Serialization;

internal sealed class ObjectHolder
{
	private object m_object; //Field offset: 0x10
	internal long m_id; //Field offset: 0x18
	private int m_missingElementsRemaining; //Field offset: 0x20
	private int m_missingDecendents; //Field offset: 0x24
	internal SerializationInfo m_serInfo; //Field offset: 0x28
	internal ISerializationSurrogate m_surrogate; //Field offset: 0x30
	internal FixupHolderList m_missingElements; //Field offset: 0x38
	internal LongList m_dependentObjects; //Field offset: 0x40
	internal ObjectHolder m_next; //Field offset: 0x48
	internal int m_flags; //Field offset: 0x50
	private bool m_markForFixupWhenAvailable; //Field offset: 0x54
	private ValueTypeFixupInfo m_valueFixup; //Field offset: 0x58
	private TypeLoadExceptionHolder m_typeLoad; //Field offset: 0x60
	private bool m_reachable; //Field offset: 0x68

	internal bool CanObjectValueChange
	{
		internal get { } //Length: 25
	}

	internal bool CanSurrogatedObjectValueChange
	{
		internal get { } //Length: 145
	}

	internal bool CompletelyFixed
	{
		internal get { } //Length: 29
	}

	internal long ContainerID
	{
		internal get { } //Length: 19
	}

	internal LongList DependentObjects
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal int DirectlyDependentObjects
	{
		internal get { } //Length: 4
	}

	internal bool HasISerializable
	{
		internal get { } //Length: 8
	}

	internal bool HasSurrogate
	{
		internal get { } //Length: 8
	}

	internal bool IsIncompleteObjectReference
	{
		internal get { } //Length: 8
		internal set { } //Length: 25
	}

	internal object ObjectValue
	{
		internal get { } //Length: 5
	}

	internal bool Reachable
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool RequiresDelayedFixup
	{
		internal get { } //Length: 8
	}

	internal bool RequiresSerInfoFixup
	{
		internal get { } //Length: 20
		internal set { } //Length: 27
	}

	internal bool RequiresValueTypeFixup
	{
		internal get { } //Length: 8
	}

	internal SerializationInfo SerializationInfo
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal ISerializationSurrogate Surrogate
	{
		internal get { } //Length: 5
	}

	internal int TotalDependentObjects
	{
		internal get { } //Length: 7
	}

	internal TypeLoadExceptionHolder TypeLoadException
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal bool TypeLoadExceptionReachable
	{
		internal get { } //Length: 9
	}

	internal ValueTypeFixupInfo ValueFixup
	{
		internal get { } //Length: 5
	}

	internal bool ValueTypeFixupPerformed
	{
		internal get { } //Length: 41
		internal set { } //Length: 12
	}

	internal ObjectHolder(long objID) { }

	internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Int32[] arrayIndex) { }

	internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Int32[] arrayIndex) { }

	internal void AddDependency(long dependentObject) { }

	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	internal bool get_CanObjectValueChange() { }

	internal bool get_CanSurrogatedObjectValueChange() { }

	internal bool get_CompletelyFixed() { }

	internal long get_ContainerID() { }

	internal LongList get_DependentObjects() { }

	internal int get_DirectlyDependentObjects() { }

	internal bool get_HasISerializable() { }

	internal bool get_HasSurrogate() { }

	internal bool get_IsIncompleteObjectReference() { }

	internal object get_ObjectValue() { }

	internal bool get_Reachable() { }

	internal bool get_RequiresDelayedFixup() { }

	internal bool get_RequiresSerInfoFixup() { }

	internal bool get_RequiresValueTypeFixup() { }

	internal SerializationInfo get_SerializationInfo() { }

	internal ISerializationSurrogate get_Surrogate() { }

	internal int get_TotalDependentObjects() { }

	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	internal bool get_TypeLoadExceptionReachable() { }

	internal ValueTypeFixupInfo get_ValueFixup() { }

	internal bool get_ValueTypeFixupPerformed() { }

	private void IncrementDescendentFixups(int amount) { }

	internal void MarkForCompletionWhenAvailable() { }

	internal void RemoveDependency(long id) { }

	internal void set_DependentObjects(LongList value) { }

	internal void set_IsIncompleteObjectReference(bool value) { }

	internal void set_Reachable(bool value) { }

	internal void set_RequiresSerInfoFixup(bool value) { }

	internal void set_SerializationInfo(SerializationInfo value) { }

	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	internal void set_ValueTypeFixupPerformed(bool value) { }

	internal void SetFlags() { }

	internal void SetObjectValue(object obj, ObjectManager manager) { }

	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, Int32[] arrayIndex, ObjectManager manager) { }

	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

}

