namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VertexAttribute <attribute>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VertexAttributeFormat <format>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <dimension>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <stream>k__BackingField; //Field offset: 0xC

	public VertexAttribute attribute
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public int dimension
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public VertexAttributeFormat format
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int stream
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public VertexAttributeDescriptor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(VertexAttributeDescriptor other) { }

	[CompilerGenerated]
	[IsReadOnly]
	public VertexAttribute get_attribute() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_dimension() { }

	[CompilerGenerated]
	[IsReadOnly]
	public VertexAttributeFormat get_format() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_stream() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public void set_attribute(VertexAttribute value) { }

	[CompilerGenerated]
	public void set_dimension(int value) { }

	[CompilerGenerated]
	public void set_format(VertexAttributeFormat value) { }

	[CompilerGenerated]
	public void set_stream(int value) { }

	public virtual string ToString() { }

}

