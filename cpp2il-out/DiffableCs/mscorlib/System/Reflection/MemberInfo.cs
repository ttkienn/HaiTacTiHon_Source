namespace System.Reflection;

public abstract class MemberInfo : ICustomAttributeProvider
{

	public override IEnumerable<CustomAttributeData> CustomAttributes
	{
		 get { } //Length: 20
	}

	public abstract Type DeclaringType
	{
		 get { } //Length: 0
	}

	public abstract MemberTypes MemberType
	{
		 get { } //Length: 0
	}

	public override int MetadataToken
	{
		 get { } //Length: 62
	}

	public override Module Module
	{
		 get { } //Length: 218
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public abstract Type ReflectedType
	{
		 get { } //Length: 0
	}

	protected MemberInfo() { }

	public virtual bool Equals(object obj) { }

	public override IEnumerable<CustomAttributeData> get_CustomAttributes() { }

	public abstract Type get_DeclaringType() { }

	public abstract MemberTypes get_MemberType() { }

	public override int get_MetadataToken() { }

	public override Module get_Module() { }

	public abstract string get_Name() { }

	public abstract Type get_ReflectedType() { }

	public abstract Object[] GetCustomAttributes(bool inherit) { }

	public abstract Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	public virtual int GetHashCode() { }

	public abstract bool IsDefined(Type attributeType, bool inherit) { }

	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

}

