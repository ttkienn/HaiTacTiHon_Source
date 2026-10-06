namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class ReflectionAttributeProvider : IAttributeProvider
{
	private readonly object _attributeProvider; //Field offset: 0x10

	public ReflectionAttributeProvider(object attributeProvider) { }

	public override IList<Attribute> GetAttributes(bool inherit) { }

	public override IList<Attribute> GetAttributes(Type attributeType, bool inherit) { }

}

