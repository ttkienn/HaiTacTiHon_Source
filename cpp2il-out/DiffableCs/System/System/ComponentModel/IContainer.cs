namespace System.ComponentModel;

public interface IContainer : IDisposable
{

	public ComponentCollection Components
	{
		 get { } //Length: 0
	}

	public ComponentCollection get_Components() { }

	public void Remove(IComponent component) { }

}

