namespace System.ComponentModel.Design;

public interface IDesignerHost : IServiceProvider
{

	public IComponent RootComponent
	{
		 get { } //Length: 0
	}

	public IComponent get_RootComponent() { }

	public IDesigner GetDesigner(IComponent component) { }

}

