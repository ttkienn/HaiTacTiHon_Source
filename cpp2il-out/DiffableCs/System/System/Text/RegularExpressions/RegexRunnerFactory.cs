namespace System.Text.RegularExpressions;

public abstract class RegexRunnerFactory
{

	protected RegexRunnerFactory() { }

	protected private abstract RegexRunner CreateInstance() { }

}

