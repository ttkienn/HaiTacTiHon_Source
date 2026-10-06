namespace System.Runtime.CompilerServices;

public class StrongBox : IStrongBox
{
	public T Value; //Field offset: 0x0

	private override object System.Runtime.CompilerServices.IStrongBox.Value
	{
		private get { } //Length: 40
		private set { } //Length: 103
	}

	public StrongBox`1() { }

	public StrongBox`1(T value) { }

	private override object System.Runtime.CompilerServices.IStrongBox.get_Value() { }

	private override void System.Runtime.CompilerServices.IStrongBox.set_Value(object value) { }

}

