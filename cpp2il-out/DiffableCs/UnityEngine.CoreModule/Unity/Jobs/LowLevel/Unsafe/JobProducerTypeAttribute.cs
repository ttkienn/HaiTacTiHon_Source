namespace Unity.Jobs.LowLevel.Unsafe;

[AttributeUsage(AttributeTargets::Interface (1024))]
public sealed class JobProducerTypeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Type <ProducerType>k__BackingField; //Field offset: 0x10

	public JobProducerTypeAttribute(Type producerType) { }

}

