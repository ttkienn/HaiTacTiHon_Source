namespace UnityEngine.Scripting.APIUpdating;

internal struct MovedFromAttributeData
{
	public string className; //Field offset: 0x0
	public string nameSpace; //Field offset: 0x8
	public string assembly; //Field offset: 0x10
	public bool classHasChanged; //Field offset: 0x18
	public bool nameSpaceHasChanged; //Field offset: 0x19
	public bool assemblyHasChanged; //Field offset: 0x1A
	public bool autoUdpateAPI; //Field offset: 0x1B

	public void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) { }

}

