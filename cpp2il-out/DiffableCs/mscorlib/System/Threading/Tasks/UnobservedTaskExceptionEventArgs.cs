namespace System.Threading.Tasks;

public class UnobservedTaskExceptionEventArgs : EventArgs
{
	private AggregateException m_exception; //Field offset: 0x10
	internal bool m_observed; //Field offset: 0x18

	public UnobservedTaskExceptionEventArgs(AggregateException exception) { }

}

