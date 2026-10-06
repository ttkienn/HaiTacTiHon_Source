namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class ReflectionValueProvider : IValueProvider
{
	private readonly MemberInfo _memberInfo; //Field offset: 0x10

	public ReflectionValueProvider(MemberInfo memberInfo) { }

	public override object GetValue(object target) { }

	public override void SetValue(object target, object value) { }

}

