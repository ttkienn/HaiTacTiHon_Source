namespace System.Reflection;

public abstract class Module : ICustomAttributeProvider, ISerializable, _Module
{
	public static readonly TypeFilter FilterTypeName; //Field offset: 0x0
	private const BindingFlags DefaultLookup = 28; //Field offset: 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; //Field offset: 0x8

	public override Assembly Assembly
	{
		 get { } //Length: 39
	}

	public override Guid ModuleVersionId
	{
		 get { } //Length: 39
	}

	public override string ScopeName
	{
		 get { } //Length: 39
	}

	private static Module() { }

	protected Module() { }

	public virtual bool Equals(object o) { }

	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	public override Assembly get_Assembly() { }

	public override Guid get_ModuleVersionId() { }

	public override string get_ScopeName() { }

	public override Object[] GetCustomAttributes(bool inherit) { }

	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual int GetHashCode() { }

	internal override Guid GetModuleVersionId() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	public override bool IsResource() { }

	public static bool op_Equality(Module left, Module right) { }

	public virtual string ToString() { }

}

