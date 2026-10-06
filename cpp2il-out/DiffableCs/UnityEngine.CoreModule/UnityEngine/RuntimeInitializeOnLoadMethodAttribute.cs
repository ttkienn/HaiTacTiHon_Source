namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False)]
[RequiredByNativeCode]
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
{
	private RuntimeInitializeLoadType m_LoadType; //Field offset: 0x10

	private RuntimeInitializeLoadType loadType
	{
		private set { } //Length: 4
	}

	public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType) { }

	private void set_loadType(RuntimeInitializeLoadType value) { }

}

