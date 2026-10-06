namespace UnityEngine.Rendering;

[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
[RequireComponent(typeof(Transform))]
public sealed class SortingGroup : Behaviour
{

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	internal static int invalidSortingGroupID
	{
		internal get { } //Length: 42
	}

	public int sortingLayerID
	{
		 get { } //Length: 51
	}

	public int sortingOrder
	{
		 get { } //Length: 51
	}

	public SortingGroup() { }

	internal static int get_invalidSortingGroupID() { }

	public int get_sortingLayerID() { }

	public int get_sortingOrder() { }

	[StaticAccessor("SortingGroup", StaticAccessorType::DoubleColon (2))]
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

}

