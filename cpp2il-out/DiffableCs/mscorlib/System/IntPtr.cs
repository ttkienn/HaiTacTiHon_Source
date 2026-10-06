namespace System;

[ComVisible(True)]
[IsReadOnly]
public struct IntPtr : ISerializable, IEquatable<IntPtr>
{
	public static readonly IntPtr Zero; //Field offset: 0x0
	private readonly Void* m_value; //Field offset: 0x0

	public static int Size
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 6
	}

	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public IntPtr(int value) { }

	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public IntPtr(long value) { }

	[CLSCompliant(False)]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public IntPtr(Void* value) { }

	private IntPtr(SerializationInfo info, StreamingContext context) { }

	public virtual bool Equals(object obj) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static int get_Size() { }

	public virtual int GetHashCode() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	internal bool IsNull() { }

	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Addition(IntPtr pointer, int offset) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[CLSCompliant(False)]
	public static Void* op_Explicit(IntPtr value) { }

	public static int op_Explicit(IntPtr value) { }

	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Explicit(long value) { }

	[CLSCompliant(False)]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Explicit(Void* value) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static IntPtr op_Subtraction(IntPtr pointer, int offset) { }

	private override bool System.IEquatable<System.IntPtr>.Equals(IntPtr other) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public long ToInt64() { }

	[CLSCompliant(False)]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public Void* ToPointer() { }

	public virtual string ToString() { }

	public string ToString(string format) { }

}

