namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Renderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public class Renderer : Component
{

	internal int sortingGroupID
	{
		internal get { } //Length: 51
	}

	internal int sortingGroupOrder
	{
		internal get { } //Length: 51
	}

	public int sortingLayerID
	{
		 get { } //Length: 51
	}

	public int sortingOrder
	{
		 get { } //Length: 51
	}

	public Renderer() { }

	internal int get_sortingGroupID() { }

	internal int get_sortingGroupOrder() { }

	public int get_sortingLayerID() { }

	public int get_sortingOrder() { }

}

