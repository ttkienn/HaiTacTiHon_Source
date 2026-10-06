namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryCrossAppDomainAssembly
{
	internal int assemId; //Field offset: 0x10
	internal int assemblyIndex; //Field offset: 0x14

	internal BinaryCrossAppDomainAssembly() { }

	public void Dump() { }

	public override void Read(__BinaryParser input) { }

}

