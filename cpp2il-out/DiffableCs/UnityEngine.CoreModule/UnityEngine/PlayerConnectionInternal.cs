namespace UnityEngine;

[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
{

	public PlayerConnectionInternal() { }

	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	private static void DisconnectAll() { }

	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	private static void Initialize() { }

	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	private static bool IsConnected() { }

	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	private static void PollInternal() { }

	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	private static void RegisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	private static void SendMessage(string messageId, Byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	private static bool TrySendMessage(string messageId, Byte[] data, int playerId) { }

	private override void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	private override void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	private override bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	private override void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	private override void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	private override void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, int playerId) { }

	private override bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	private override void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	private static void UnregisterInternal(string messageId) { }

}

