namespace System.Runtime.Remoting;

internal class TypeInfo : IRemotingTypeInfo
{
	private string serverType; //Field offset: 0x10
	private String[] serverHierarchy; //Field offset: 0x18
	private String[] interfacesImplemented; //Field offset: 0x20

	public override string TypeName
	{
		 get { } //Length: 5
	}

	public TypeInfo(Type type) { }

	public override bool CanCastTo(Type fromType, object o) { }

	public override string get_TypeName() { }

}

