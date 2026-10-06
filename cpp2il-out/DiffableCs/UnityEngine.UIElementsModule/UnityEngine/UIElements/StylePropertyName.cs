namespace UnityEngine.UIElements;

public struct StylePropertyName : IEquatable<StylePropertyName>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly StylePropertyId <id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <name>k__BackingField; //Field offset: 0x8

	internal StylePropertyId id
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 3
	}

	private string name
	{
		[CompilerGenerated]
		[IsReadOnly]
		private get { } //Length: 5
	}

	internal StylePropertyName(StylePropertyId stylePropertyId) { }

	public StylePropertyName(string name) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(StylePropertyName other) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal StylePropertyId get_id() { }

	[CompilerGenerated]
	[IsReadOnly]
	private string get_name() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StylePropertyName lhs, StylePropertyName rhs) { }

	public static StylePropertyName op_Implicit(string name) { }

	public static bool op_Inequality(StylePropertyName lhs, StylePropertyName rhs) { }

	internal static StylePropertyId StylePropertyIdFromString(string name) { }

	public virtual string ToString() { }

}

