namespace System.ComponentModel;

public interface ITypeDescriptorContext : IServiceProvider
{

	public IContainer Container
	{
		 get { } //Length: 0
	}

	public IContainer get_Container() { }

}

