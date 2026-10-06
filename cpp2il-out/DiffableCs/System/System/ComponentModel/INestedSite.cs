namespace System.ComponentModel;

public interface INestedSite : ISite, IServiceProvider
{

	public string FullName
	{
		 get { } //Length: 0
	}

	public string get_FullName() { }

}

