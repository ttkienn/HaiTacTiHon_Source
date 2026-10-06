namespace System;

public abstract class FormattableString : IFormattable
{

	public abstract int ArgumentCount
	{
		 get { } //Length: 0
	}

	public abstract string Format
	{
		 get { } //Length: 0
	}

	protected FormattableString() { }

	public abstract int get_ArgumentCount() { }

	public abstract string get_Format() { }

	public abstract object GetArgument(int index) { }

	public abstract Object[] GetArguments() { }

	private override string System.IFormattable.ToString(string ignored, IFormatProvider formatProvider) { }

	public abstract string ToString(IFormatProvider formatProvider) { }

	public virtual string ToString() { }

}

