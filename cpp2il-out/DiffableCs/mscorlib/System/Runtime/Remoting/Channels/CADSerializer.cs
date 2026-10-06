namespace System.Runtime.Remoting.Channels;

internal class CADSerializer
{

	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	internal static object DeserializeObject(MemoryStream mem) { }

	internal static object DeserializeObjectSafe(Byte[] mem) { }

	internal static MemoryStream SerializeMessage(IMessage msg) { }

	internal static MemoryStream SerializeObject(object obj) { }

}

