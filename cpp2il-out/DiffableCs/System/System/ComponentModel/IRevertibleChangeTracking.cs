namespace System.ComponentModel;

public interface IRevertibleChangeTracking : IChangeTracking
{

	public void RejectChanges() { }

}

