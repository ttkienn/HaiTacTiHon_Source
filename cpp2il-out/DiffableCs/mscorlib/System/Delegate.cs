namespace System;

public abstract class Delegate : ICloneable, ISerializable
{
	private IntPtr method_ptr; //Field offset: 0x10
	private IntPtr invoke_impl; //Field offset: 0x18
	private object m_target; //Field offset: 0x20
	private IntPtr method; //Field offset: 0x28
	private IntPtr delegate_trampoline; //Field offset: 0x30
	private IntPtr extra_arg; //Field offset: 0x38
	private IntPtr method_code; //Field offset: 0x40
	private IntPtr interp_method; //Field offset: 0x48
	private IntPtr interp_invoke_impl; //Field offset: 0x50
	private MethodInfo method_info; //Field offset: 0x58
	private MethodInfo original_method_info; //Field offset: 0x60
	private DelegateData data; //Field offset: 0x68
	private bool method_is_virtual; //Field offset: 0x70

	public MethodInfo Method
	{
		 get { } //Length: 20
	}

	public object Target
	{
		 get { } //Length: 5
	}

	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }

	private static bool arg_type_match(Type delArgType, Type argType) { }

	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	public override object Clone() { }

	[ComVisible(True)]
	public static Delegate Combine(Delegate[] delegates) { }

	public static Delegate Combine(Delegate a, Delegate b) { }

	protected override Delegate CombineImpl(Delegate d) { }

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, object target, string method) { }

	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	public virtual bool Equals(object obj) { }

	public MethodInfo get_Method() { }

	public object get_Target() { }

	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	public virtual int GetHashCode() { }

	public override Delegate[] GetInvocationList() { }

	protected override MethodInfo GetMethodImpl() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private MethodInfo GetVirtualMethod_internal() { }

	public static bool op_Equality(Delegate d1, Delegate d2) { }

	public static bool op_Inequality(Delegate d1, Delegate d2) { }

	public static Delegate Remove(Delegate source, Delegate value) { }

	protected override Delegate RemoveImpl(Delegate d) { }

	private static bool return_type_match(Type delReturnType, Type returnType) { }

}

