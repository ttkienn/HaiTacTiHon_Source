namespace Unity.Properties;

public class SetPropertyBagBase : PropertyBag<TSet>, IPropertyBag<TSet>, IPropertyBag
{
	private class SetElementProperty : Property<TSet, TElement>
	{
		internal TElement m_Value; //Field offset: 0x0

		public virtual string Name
		{
			 get { } //Length: 230
		}

		public SetElementProperty() { }

		public virtual string get_Name() { }

	}

	private readonly SetElementProperty<TSet, TElement> m_Property; //Field offset: 0x0

	public SetPropertyBagBase`2() { }

}

