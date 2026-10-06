namespace Newtonsoft.Json;

public interface IJsonLineInfo
{

	public int LineNumber
	{
		 get { } //Length: 0
	}

	public int LinePosition
	{
		 get { } //Length: 0
	}

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public bool HasLineInfo() { }

}

