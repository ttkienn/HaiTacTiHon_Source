namespace System;

[CLSCompliant(False)]
[ComVisible(True)]
[IsByRefLike]
[NonVersionable]
public struct TypedReference
{
	private RuntimeTypeHandle type; //Field offset: 0x0
	private IntPtr Value; //Field offset: 0x8
	private IntPtr Type; //Field offset: 0x10

	internal bool IsNull
	{
		internal get { } //Length: 19
	}

	public virtual bool Equals(object o) { }

	internal bool get_IsNull() { }

	public virtual int GetHashCode() { }

	private static void InternalMakeTypedReference(Void* result, object target, IntPtr[] flds, RuntimeType lastFieldType) { }

	[CLSCompliant(False)]
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	[CLSCompliant(False)]
	public static void SetTypedReference(TypedReference target, object value) { }

}

