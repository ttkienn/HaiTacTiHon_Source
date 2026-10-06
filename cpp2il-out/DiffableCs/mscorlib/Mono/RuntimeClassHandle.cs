namespace Mono;

internal struct RuntimeClassHandle
{
	private MonoClass* value; //Field offset: 0x0

	internal MonoClass* Value
	{
		internal get { } //Length: 4
	}

	internal RuntimeClassHandle(MonoClass* value) { }

	internal RuntimeClassHandle(IntPtr ptr) { }

	public virtual bool Equals(object obj) { }

	internal MonoClass* get_Value() { }

	public virtual int GetHashCode() { }

	internal static IntPtr GetTypeFromClass(MonoClass* klass) { }

	internal RuntimeTypeHandle GetTypeHandle() { }

}

