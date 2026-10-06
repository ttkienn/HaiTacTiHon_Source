namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[UsedByNativeCode]
public struct Quaternion : IEquatable<Quaternion>, IFormattable
{
	private static readonly Quaternion identityQuaternion; //Field offset: 0x0
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8
	public float w; //Field offset: 0xC

	public static Quaternion identity
	{
		 get { } //Length: 66
	}

	private static Quaternion() { }

	public Quaternion(float x, float y, float z, float w) { }

	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	public static float Dot(Quaternion a, Quaternion b) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(Quaternion other) { }

	public static Quaternion Euler(float x, float y, float z) { }

	public static Quaternion get_identity() { }

	public virtual int GetHashCode() { }

	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	[FreeFunction(IsThreadSafe = True)]
	public static Quaternion Inverse(Quaternion rotation) { }

	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	private static bool IsEqualUsingDot(float dot) { }

	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

