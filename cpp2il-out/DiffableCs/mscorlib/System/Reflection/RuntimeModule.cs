namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Module))]
[ComVisible(True)]
internal class RuntimeModule : Module
{
	internal IntPtr _impl; //Field offset: 0x10
	internal Assembly assembly; //Field offset: 0x18
	internal string fqname; //Field offset: 0x20
	internal string name; //Field offset: 0x28
	internal string scopename; //Field offset: 0x30
	internal bool is_resource; //Field offset: 0x38
	internal int token; //Field offset: 0x3C

	public virtual Assembly Assembly
	{
		 get { } //Length: 5
	}

	public virtual Guid ModuleVersionId
	{
		 get { } //Length: 48
	}

	public virtual string ScopeName
	{
		 get { } //Length: 5
	}

	public RuntimeModule() { }

	public virtual Assembly get_Assembly() { }

	public virtual Guid get_ModuleVersionId() { }

	public virtual string get_ScopeName() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	private static void GetGuidInternal(IntPtr module, Byte[] guid) { }

	internal virtual Guid GetModuleVersionId() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal RuntimeAssembly GetRuntimeAssembly() { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual bool IsResource() { }

}

