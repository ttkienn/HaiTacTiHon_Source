namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[NullableContext(1)]
public interface IJEnumerable : IEnumerable<T>, IEnumerable
{

	public IJEnumerable<JToken> Item
	{
		 get { } //Length: 0
	}

	public IJEnumerable<JToken> get_Item(object key) { }

}

