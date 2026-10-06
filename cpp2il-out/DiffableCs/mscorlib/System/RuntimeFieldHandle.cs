namespace System;

[ComVisible(True)]
public struct RuntimeFieldHandle : ISerializable
{
	private IntPtr value; //Field offset: 0x0

	public IntPtr Value
	{
		 get { } //Length: 4
	}

	internal RuntimeFieldHandle(IntPtr v) { }

	private RuntimeFieldHandle(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public virtual bool Equals(object obj) { }

	public IntPtr get_Value() { }

	public virtual int GetHashCode() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	internal static void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, Void* pTypedRef, object value, RuntimeType contextType) { }

	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

}

