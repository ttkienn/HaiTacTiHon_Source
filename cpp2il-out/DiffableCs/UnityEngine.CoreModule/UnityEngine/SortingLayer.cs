namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/TagManager.h")]
public struct SortingLayer
{
	private int m_Id; //Field offset: 0x0

	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	public static int GetLayerValueFromID(int id) { }

}

