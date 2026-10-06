namespace System.ComponentModel;

public interface ISite : IServiceProvider
{

	public IContainer Container
	{
		 get { } //Length: 0
	}

	public bool DesignMode
	{
		 get { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
	}

	public IContainer get_Container() { }

	public bool get_DesignMode() { }

	public string get_Name() { }

}

