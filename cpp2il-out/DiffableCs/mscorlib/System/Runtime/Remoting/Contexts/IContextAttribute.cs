namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public interface IContextAttribute
{

	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }

}

