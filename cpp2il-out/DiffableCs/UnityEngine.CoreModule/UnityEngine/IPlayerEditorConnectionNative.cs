namespace UnityEngine;

internal interface IPlayerEditorConnectionNative
{

	public void DisconnectAll() { }

	public void Initialize() { }

	public bool IsConnected() { }

	public void Poll() { }

	public void RegisterInternal(Guid messageId) { }

	public void SendMessage(Guid messageId, Byte[] data, int playerId) { }

	public bool TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	public void UnregisterInternal(Guid messageId) { }

}

