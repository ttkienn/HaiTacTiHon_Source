namespace UnityEngine;

[AttributeUsage(AttributeTargets::Enum (16))]
public sealed class InspectorOrderAttribute : PropertyAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private InspectorSort <m_inspectorSort>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private InspectorSortDirection <m_sortDirection>k__BackingField; //Field offset: 0x14

	internal InspectorSort m_inspectorSort
	{
		[CompilerGenerated]
		internal get { } //Length: 191
	}

	internal InspectorSortDirection m_sortDirection
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	[CompilerGenerated]
	internal InspectorSort get_m_inspectorSort() { }

	[CompilerGenerated]
	internal InspectorSortDirection get_m_sortDirection() { }

}

