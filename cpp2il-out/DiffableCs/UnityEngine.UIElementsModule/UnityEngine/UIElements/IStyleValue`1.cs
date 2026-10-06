namespace UnityEngine.UIElements;

internal interface IStyleValue
{

	public StyleKeyword keyword
	{
		 get { } //Length: 0
	}

	public T value
	{
		 get { } //Length: 0
	}

	public StyleKeyword get_keyword() { }

	public T get_value() { }

}

