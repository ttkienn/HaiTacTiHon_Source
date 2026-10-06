namespace UnityEngine.UIElements;

internal interface IUIElementsUtility
{

	public bool CleanupRoots() { }

	public bool EndContainerGUIFromException(Exception exception) { }

	public bool MakeCurrentIMGUIContainerDirty() { }

	public bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	public bool ReleaseCapture() { }

	public bool TakeCapture() { }

}

