namespace UnityEngine.Scripting.APIUpdating;

[AttributeUsage(5148)]
public class MovedFromAttribute : Attribute
{
	internal MovedFromAttributeData data; //Field offset: 0x10

	public MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) { }

	public MovedFromAttribute(string sourceNamespace) { }

}

