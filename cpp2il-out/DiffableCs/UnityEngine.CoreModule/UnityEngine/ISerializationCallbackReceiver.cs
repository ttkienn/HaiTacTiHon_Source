namespace UnityEngine;

[RequiredByNativeCode]
public interface ISerializationCallbackReceiver
{

	[RequiredByNativeCode]
	public void OnAfterDeserialize() { }

	[RequiredByNativeCode]
	public void OnBeforeSerialize() { }

}

