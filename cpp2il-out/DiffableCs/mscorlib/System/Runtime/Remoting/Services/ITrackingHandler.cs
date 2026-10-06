namespace System.Runtime.Remoting.Services;

[ComVisible(True)]
public interface ITrackingHandler
{

	public void DisconnectedObject(object obj) { }

	public void MarshaledObject(object obj, ObjRef or) { }

	public void UnmarshaledObject(object obj, ObjRef or) { }

}

