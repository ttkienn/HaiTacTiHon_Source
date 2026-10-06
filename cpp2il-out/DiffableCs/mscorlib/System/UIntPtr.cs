namespace System;

[CLSCompliant(False)]
[ComVisible(True)]
[IsReadOnly]
public struct UIntPtr : ISerializable, IEquatable<UIntPtr>
{
	public static readonly UIntPtr Zero; //Field offset: 0x0
	private readonly Void* _pointer; //Field offset: 0x0

	public static int Size
	{
		 get { } //Length: 6
	}

	private static UIntPtr() { }

	public UIntPtr(ulong value) { }

	public UIntPtr(uint value) { }

	[CLSCompliant(False)]
	public UIntPtr(Void* value) { }

	public virtual bool Equals(object obj) { }

	public static int get_Size() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	public static UIntPtr op_Explicit(ulong value) { }

	public static UIntPtr op_Explicit(uint value) { }

	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	private override bool System.IEquatable<System.UIntPtr>.Equals(UIntPtr other) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

