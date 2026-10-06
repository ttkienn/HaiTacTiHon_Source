namespace System.Reflection;

public abstract class EventInfo : MemberInfo
{
	private sealed class AddEventAdapter : MulticastDelegate
	{

		public AddEventAdapter(object object, IntPtr method) { }

		public override void Invoke(object _this, Delegate dele) { }

	}

	private AddEventAdapter cached_add_event; //Field offset: 0x10

	public override Type EventHandlerType
	{
		 get { } //Length: 301
	}

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 6
	}

	protected EventInfo() { }

	public virtual bool Equals(object obj) { }

	public override Type get_EventHandlerType() { }

	public virtual MemberTypes get_MemberType() { }

	public override MethodInfo GetAddMethod() { }

	public abstract MethodInfo GetAddMethod(bool nonPublic) { }

	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }

	public virtual int GetHashCode() { }

	public abstract MethodInfo GetRaiseMethod(bool nonPublic) { }

	public override MethodInfo GetRemoveMethod() { }

	public abstract MethodInfo GetRemoveMethod(bool nonPublic) { }

	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	public static bool op_Equality(EventInfo left, EventInfo right) { }

	public static bool op_Inequality(EventInfo left, EventInfo right) { }

}

