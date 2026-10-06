namespace UnityEngine.UI;

public class ClipperRegistry
{
	private static ClipperRegistry s_Instance; //Field offset: 0x0
	private readonly IndexedSet<IClipper> m_Clippers; //Field offset: 0x10

	public static ClipperRegistry instance
	{
		 get { } //Length: 241
	}

	protected ClipperRegistry() { }

	public void Cull() { }

	public static void Disable(IClipper c) { }

	public static ClipperRegistry get_instance() { }

	public static void Register(IClipper c) { }

	public static void Unregister(IClipper c) { }

}

