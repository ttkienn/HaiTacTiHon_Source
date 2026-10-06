namespace Unity.Properties.Internal;

internal class Vector2PropertyBag : ContainerPropertyBag<Vector2>
{
	private class XProperty : Property<Vector2, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public XProperty() { }

		public virtual string get_Name() { }

	}

	private class YProperty : Property<Vector2, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public YProperty() { }

		public virtual string get_Name() { }

	}


	public Vector2PropertyBag() { }

}

