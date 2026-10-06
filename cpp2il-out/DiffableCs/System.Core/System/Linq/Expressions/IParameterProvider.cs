namespace System.Linq.Expressions;

internal interface IParameterProvider
{

	public int ParameterCount
	{
		 get { } //Length: 0
	}

	public int get_ParameterCount() { }

	public ParameterExpression GetParameter(int index) { }

}

