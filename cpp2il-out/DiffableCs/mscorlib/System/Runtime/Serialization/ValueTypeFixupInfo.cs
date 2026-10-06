namespace System.Runtime.Serialization;

internal sealed class ValueTypeFixupInfo
{
	private readonly long _containerID; //Field offset: 0x10
	private readonly FieldInfo _parentField; //Field offset: 0x18
	private readonly Int32[] _parentIndex; //Field offset: 0x20

	public long ContainerID
	{
		 get { } //Length: 5
	}

	public FieldInfo ParentField
	{
		 get { } //Length: 5
	}

	public Int32[] ParentIndex
	{
		 get { } //Length: 5
	}

	public ValueTypeFixupInfo(long containerID, FieldInfo member, Int32[] parentIndex) { }

	public long get_ContainerID() { }

	public FieldInfo get_ParentField() { }

	public Int32[] get_ParentIndex() { }

}

