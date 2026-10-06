namespace Unity.Properties.Internal;

internal class ColorPropertyBag : ContainerPropertyBag<Color>
{
	private class AProperty : Property<Color, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public AProperty() { }

		public virtual string get_Name() { }

	}

	private class BProperty : Property<Color, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public BProperty() { }

		public virtual string get_Name() { }

	}

	private class GProperty : Property<Color, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public GProperty() { }

		public virtual string get_Name() { }

	}

	private class RProperty : Property<Color, Single>
	{

		public virtual string Name
		{
			 get { } //Length: 44
		}

		public RProperty() { }

		public virtual string get_Name() { }

	}


	public ColorPropertyBag() { }

}

