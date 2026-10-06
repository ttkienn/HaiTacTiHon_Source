namespace System.Data.SqlTypes;

public interface INullable
{

	public bool IsNull
	{
		 get { } //Length: 0
	}

	public bool get_IsNull() { }

}

