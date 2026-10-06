namespace System.Data;

internal interface IFilter
{

	public bool Invoke(DataRow row, DataRowVersion version) { }

}

