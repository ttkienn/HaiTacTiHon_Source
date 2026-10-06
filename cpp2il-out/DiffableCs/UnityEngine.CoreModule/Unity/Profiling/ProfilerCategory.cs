namespace Unity.Profiling;

[IsReadOnly]
[UsedByNativeCode]
public struct ProfilerCategory
{
	private readonly ushort m_CategoryId; //Field offset: 0x0

	public string Name
	{
		 get { } //Length: 300
	}

	public static ProfilerCategory Scripts
	{
		 get { } //Length: 6
	}

	internal ProfilerCategory(ushort category) { }

	public string get_Name() { }

	public static ProfilerCategory get_Scripts() { }

	public static ushort op_Implicit(ProfilerCategory category) { }

	public virtual string ToString() { }

}

