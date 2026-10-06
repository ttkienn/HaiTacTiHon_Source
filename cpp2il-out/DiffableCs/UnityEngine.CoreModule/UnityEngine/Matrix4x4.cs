namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Matrix4x4f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
{
	private static readonly Matrix4x4 zeroMatrix; //Field offset: 0x0
	private static readonly Matrix4x4 identityMatrix; //Field offset: 0x40
	[NativeName("m_Data[0]")]
	public float m00; //Field offset: 0x0
	[NativeName("m_Data[1]")]
	public float m10; //Field offset: 0x4
	[NativeName("m_Data[2]")]
	public float m20; //Field offset: 0x8
	[NativeName("m_Data[3]")]
	public float m30; //Field offset: 0xC
	[NativeName("m_Data[4]")]
	public float m01; //Field offset: 0x10
	[NativeName("m_Data[5]")]
	public float m11; //Field offset: 0x14
	[NativeName("m_Data[6]")]
	public float m21; //Field offset: 0x18
	[NativeName("m_Data[7]")]
	public float m31; //Field offset: 0x1C
	[NativeName("m_Data[8]")]
	public float m02; //Field offset: 0x20
	[NativeName("m_Data[9]")]
	public float m12; //Field offset: 0x24
	[NativeName("m_Data[10]")]
	public float m22; //Field offset: 0x28
	[NativeName("m_Data[11]")]
	public float m32; //Field offset: 0x2C
	[NativeName("m_Data[12]")]
	public float m03; //Field offset: 0x30
	[NativeName("m_Data[13]")]
	public float m13; //Field offset: 0x34
	[NativeName("m_Data[14]")]
	public float m23; //Field offset: 0x38
	[NativeName("m_Data[15]")]
	public float m33; //Field offset: 0x3C

	public static Matrix4x4 identity
	{
		 get { } //Length: 91
	}

	public Matrix4x4 inverse
	{
		 get { } //Length: 173
	}

	private static Matrix4x4() { }

	public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	public virtual bool Equals(object other) { }

	public override bool Equals(Matrix4x4 other) { }

	public static Matrix4x4 get_identity() { }

	public Matrix4x4 get_inverse() { }

	public Vector4 GetColumn(int index) { }

	public virtual int GetHashCode() { }

	public Vector4 GetRow(int index) { }

	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	private static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result) { }

	public Vector3 MultiplyPoint(Vector3 point) { }

	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	public static Matrix4x4 Rotate(Quaternion q) { }

	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

}

