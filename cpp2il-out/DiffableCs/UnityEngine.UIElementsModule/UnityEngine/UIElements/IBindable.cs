namespace UnityEngine.UIElements;

public interface IBindable
{

	public IBinding binding
	{
		 get { } //Length: 0
	}

	public string bindingPath
	{
		 set { } //Length: 0
	}

	public IBinding get_binding() { }

	public void set_bindingPath(string value) { }

}

