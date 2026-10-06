namespace Unity.Properties.Internal;

internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
{
	private class XProperty : Property<Vector2Int, Int32>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public XProperty() { }

		public virtual string get_Name() { }

	}

	private class YProperty : Property<Vector2Int, Int32>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public YProperty() { }

		public virtual string get_Name() { }

	}


	public Vector2IntPropertyBag() { }

}

