namespace Unity.Properties.Internal;

internal class BoundsPropertyBag : ContainerPropertyBag<Bounds>
{
	private class CenterProperty : Property<Bounds, Vector3>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public CenterProperty() { }

		public virtual string get_Name() { }

	}

	private class ExtentsProperty : Property<Bounds, Vector3>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public ExtentsProperty() { }

		public virtual string get_Name() { }

	}


	public BoundsPropertyBag() { }

}

