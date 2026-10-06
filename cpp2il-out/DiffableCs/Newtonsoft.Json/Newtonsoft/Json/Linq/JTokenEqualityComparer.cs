namespace Newtonsoft.Json.Linq;

public class JTokenEqualityComparer : IEqualityComparer<JToken>
{

	public JTokenEqualityComparer() { }

	[NullableContext(2)]
	public override bool Equals(JToken x, JToken y) { }

	[NullableContext(1)]
	public override int GetHashCode(JToken obj) { }

}

