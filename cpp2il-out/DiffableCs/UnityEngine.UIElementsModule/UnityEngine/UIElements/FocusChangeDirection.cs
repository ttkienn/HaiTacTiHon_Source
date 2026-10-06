namespace UnityEngine.UIElements;

public class FocusChangeDirection : IDisposable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly FocusChangeDirection <unspecified>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly FocusChangeDirection <none>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly FocusChangeDirection <lastValue>k__BackingField; //Field offset: 0x10
	private readonly int m_Value; //Field offset: 0x10

	protected static FocusChangeDirection lastValue
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public static FocusChangeDirection none
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public static FocusChangeDirection unspecified
	{
		[CompilerGenerated]
		 get { } //Length: 78
	}

	private static FocusChangeDirection() { }

	protected FocusChangeDirection(int value) { }

	internal override void ApplyTo(FocusController focusController, Focusable f) { }

	protected override void Dispose() { }

	[CompilerGenerated]
	protected static FocusChangeDirection get_lastValue() { }

	[CompilerGenerated]
	public static FocusChangeDirection get_none() { }

	[CompilerGenerated]
	public static FocusChangeDirection get_unspecified() { }

	public static int op_Implicit(FocusChangeDirection fcd) { }

	private override void System.IDisposable.Dispose() { }

}

