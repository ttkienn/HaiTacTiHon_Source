namespace Unity.Properties;

public abstract class Property : IProperty<TContainer>, IProperty, IAttributes
{
	private List<Attribute> m_Attributes; //Field offset: 0x0

	public abstract string Name
	{
		 get { } //Length: 0
	}

	protected Property`2() { }

	protected void AddAttribute(Attribute attribute) { }

	protected void AddAttributes(IEnumerable<Attribute> attributes) { }

	public override Type DeclaredValueType() { }

	public abstract string get_Name() { }

	public override bool HasAttribute() { }

	private override void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	private override void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }

}

