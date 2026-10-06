namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
public struct Scene
{
	[HideInInspector]
	[SerializeField]
	private int m_Handle; //Field offset: 0x0

	public int handle
	{
		 get { } //Length: 5
	}

	public virtual bool Equals(object other) { }

	public int get_handle() { }

	public virtual int GetHashCode() { }

}

