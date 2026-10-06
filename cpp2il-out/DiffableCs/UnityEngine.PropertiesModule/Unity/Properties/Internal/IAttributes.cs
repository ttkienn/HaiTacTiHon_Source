namespace Unity.Properties.Internal;

internal interface IAttributes
{

	public void AddAttribute(Attribute attribute) { }

	public void AddAttributes(IEnumerable<Attribute> attributes) { }

}

