namespace Unity.Properties.Internal;

internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
{
	private class PositionProperty : Property<BoundsInt, Vector3Int>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public PositionProperty() { }

		public virtual string get_Name() { }

	}

	private class SizeProperty : Property<BoundsInt, Vector3Int>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public SizeProperty() { }

		public virtual string get_Name() { }

	}


	public BoundsIntPropertyBag() { }

}

