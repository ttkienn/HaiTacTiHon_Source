namespace UnityEngine.UIElements;

public interface ITransform
{

	public Vector3 position
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 scale
	{
		 get { } //Length: 0
	}

	public Vector3 get_position() { }

	public Vector3 get_scale() { }

	public void set_position(Vector3 value) { }

}

