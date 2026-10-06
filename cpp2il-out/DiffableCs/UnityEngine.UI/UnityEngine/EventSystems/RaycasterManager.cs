namespace UnityEngine.EventSystems;

public static class RaycasterManager
{
	private static readonly List<BaseRaycaster> s_Raycasters; //Field offset: 0x0

	private static RaycasterManager() { }

	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	public static List<BaseRaycaster> GetRaycasters() { }

	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

}

