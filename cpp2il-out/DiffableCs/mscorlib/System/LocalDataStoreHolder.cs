namespace System;

internal sealed class LocalDataStoreHolder
{
	private LocalDataStore m_Store; //Field offset: 0x10

	public LocalDataStore Store
	{
		 get { } //Length: 5
	}

	public LocalDataStoreHolder(LocalDataStore store) { }

	protected virtual void Finalize() { }

	public LocalDataStore get_Store() { }

}

