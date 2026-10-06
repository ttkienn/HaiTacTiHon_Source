namespace Unity.Properties;

[IsReadOnly]
internal struct FieldMember : IMemberInfo
{
	internal readonly FieldInfo m_FieldInfo; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <Name>k__BackingField; //Field offset: 0x8

	public override bool IsReadOnly
	{
		 get { } //Length: 28
	}

	public override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override Type ValueType
	{
		 get { } //Length: 41
	}

	public FieldMember(FieldInfo fieldInfo) { }

	public override bool get_IsReadOnly() { }

	[CompilerGenerated]
	public override string get_Name() { }

	public override Type get_ValueType() { }

	public override IEnumerable<Attribute> GetCustomAttributes() { }

}

