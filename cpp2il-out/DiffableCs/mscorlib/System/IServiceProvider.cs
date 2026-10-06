namespace System;

public interface IServiceProvider
{

	public object GetService(Type serviceType) { }

}

