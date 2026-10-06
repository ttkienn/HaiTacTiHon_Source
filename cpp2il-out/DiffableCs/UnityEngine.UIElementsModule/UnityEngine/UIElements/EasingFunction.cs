namespace UnityEngine.UIElements;

public struct EasingFunction : IEquatable<EasingFunction>
{
	private EasingMode m_Mode; //Field offset: 0x0

	public EasingMode mode
	{
		 get { } //Length: 3
	}

	public EasingFunction(EasingMode mode) { }

	public override bool Equals(EasingFunction other) { }

	public virtual bool Equals(object obj) { }

	public EasingMode get_mode() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	public static EasingFunction op_Implicit(EasingMode easingMode) { }

	public virtual string ToString() { }

}

