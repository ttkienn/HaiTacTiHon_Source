namespace UnityEngine.UIElements;

internal struct StyleVariable
{
	public readonly string name; //Field offset: 0x0
	public readonly StyleSheet sheet; //Field offset: 0x8
	public readonly StyleValueHandle[] handles; //Field offset: 0x10

	public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles) { }

	public virtual int GetHashCode() { }

}

