namespace Unity.Properties;

public abstract class ContainerPropertyBag : PropertyBag<TContainer>
{
	private readonly List<IProperty`1<TContainer>> m_PropertiesList; //Field offset: 0x0
	private readonly Dictionary<String, IProperty`1<TContainer>> m_PropertiesHash; //Field offset: 0x0

	private static ContainerPropertyBag`1() { }

	protected ContainerPropertyBag`1() { }

	protected void AddProperty(Property<TContainer, TValue> property) { }

	public override bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer>& property) { }

}

