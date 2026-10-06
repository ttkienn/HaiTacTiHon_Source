namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
public interface IAttributeProvider
{

	public IList<Attribute> GetAttributes(bool inherit) { }

	public IList<Attribute> GetAttributes(Type attributeType, bool inherit) { }

}

