namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
public interface ISponsor
{

	public TimeSpan Renewal(ILease lease) { }

}

