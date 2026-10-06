namespace UnityEngine;

[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
public class Cursor
{

	public static CursorLockMode lockState
	{
		 get { } //Length: 42
	}

	public static CursorLockMode get_lockState() { }

	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

}

