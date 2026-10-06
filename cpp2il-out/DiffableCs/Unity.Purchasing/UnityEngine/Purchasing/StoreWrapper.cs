namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreWrapper : IStoreWrapper
{
	private InternalStore m_InternalStore; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <name>k__BackingField; //Field offset: 0x18

	public override Store instance
	{
		 get { } //Length: 5
	}

	public override string name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StoreWrapper(string name, InternalStore instance) { }

	public override Store get_instance() { }

	[CompilerGenerated]
	public override string get_name() { }

	public override ConnectionState GetStoreConnectionState() { }

}

