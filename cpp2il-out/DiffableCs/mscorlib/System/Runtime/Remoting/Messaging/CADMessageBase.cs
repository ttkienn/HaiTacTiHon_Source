namespace System.Runtime.Remoting.Messaging;

internal class CADMessageBase
{
	protected Object[] _args; //Field offset: 0x10
	protected Byte[] _serializedArgs; //Field offset: 0x18
	protected int _propertyCount; //Field offset: 0x20
	protected CADArgHolder _callContext; //Field offset: 0x28
	internal Byte[] serializedMethod; //Field offset: 0x30

	public CADMessageBase(IMethodMessage msg) { }

	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }

	internal MethodBase GetMethod() { }

	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	protected object MarshalArgument(object arg, ref ArrayList args) { }

	internal Object[] MarshalArguments(Object[] arguments, ref ArrayList args) { }

	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	protected object UnmarshalArgument(object arg, ArrayList args) { }

	internal Object[] UnmarshalArguments(Object[] arguments, ArrayList args) { }

	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

}

