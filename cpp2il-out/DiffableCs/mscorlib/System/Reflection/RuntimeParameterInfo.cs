namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_ParameterInfo))]
[ComVisible(True)]
internal class RuntimeParameterInfo : ParameterInfo
{
	internal MarshalAsAttribute marshalAs; //Field offset: 0x40

	public virtual object DefaultValue
	{
		 get { } //Length: 810
	}

	internal RuntimeParameterInfo(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs) { }

	internal RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member) { }

	internal RuntimeParameterInfo(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	public virtual object get_DefaultValue() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	internal object GetDefaultValueImpl(ParameterInfo pinfo) { }

	internal Object[] GetPseudoCustomAttributes() { }

	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

	internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

}

