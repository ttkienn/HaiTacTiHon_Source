namespace System.Linq.Expressions;

public interface IArgumentProvider
{

	public int ArgumentCount
	{
		 get { } //Length: 0
	}

	public int get_ArgumentCount() { }

	public Expression GetArgument(int index) { }

}

