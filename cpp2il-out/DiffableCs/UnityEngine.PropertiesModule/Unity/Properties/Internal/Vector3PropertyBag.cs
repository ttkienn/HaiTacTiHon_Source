namespace Unity.Properties.Internal;

internal class Vector3PropertyBag : ContainerPropertyBag<Vector3>
{
	private class XProperty : Property<Vector3, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public XProperty() { }

		public virtual string get_Name() { }

	}

	private class YProperty : Property<Vector3, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public YProperty() { }

		public virtual string get_Name() { }

	}

	private class ZProperty : Property<Vector3, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public ZProperty() { }

		public virtual string get_Name() { }

	}


	public Vector3PropertyBag() { }

}

