namespace Unity.Properties.Internal;

internal class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int>
{
	private class XProperty : Property<Vector3Int, Int32>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public XProperty() { }

		public virtual string get_Name() { }

	}

	private class YProperty : Property<Vector3Int, Int32>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public YProperty() { }

		public virtual string get_Name() { }

	}

	private class ZProperty : Property<Vector3Int, Int32>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public ZProperty() { }

		public virtual string get_Name() { }

	}


	public Vector3IntPropertyBag() { }

}

