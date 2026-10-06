namespace UnityEngine;

[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Utilities/BitUtility.h")]
[NativeHeader("Runtime/Math/FloatConversion.h")]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
public struct Mathf
{
	public static readonly float Epsilon; //Field offset: 0x0

	private static Mathf() { }

	public static int Abs(int value) { }

	public static float Abs(float f) { }

	public static float Acos(float f) { }

	public static bool Approximately(float a, float b) { }

	public static float Atan(float f) { }

	public static float Atan2(float y, float x) { }

	public static float Ceil(float f) { }

	public static int CeilToInt(float f) { }

	public static int Clamp(int value, int min, int max) { }

	public static float Clamp(float value, float min, float max) { }

	public static float Clamp01(float value) { }

	internal static float ClampToFloat(double value) { }

	internal static int ClampToInt(long value) { }

	internal static uint ClampToUInt(long value) { }

	[FreeFunction(IsThreadSafe = True)]
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }

	public static float Cos(float f) { }

	internal static double DiscardLeastSignificantDecimal(double v) { }

	public static float Floor(float f) { }

	public static int FloorToInt(float f) { }

	[FreeFunction(IsThreadSafe = True)]
	public static float GammaToLinearSpace(float value) { }

	internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference) { }

	public static float InverseLerp(float a, float b, float value) { }

	[FreeFunction(IsThreadSafe = True)]
	public static bool IsPowerOfTwo(int value) { }

	public static float Lerp(float a, float b, float t) { }

	public static float LerpUnclamped(float a, float b, float t) { }

	public static float Log(float f, float p) { }

	public static float Log10(float f) { }

	public static int Max(int a, int b) { }

	public static float Max(float a, float b) { }

	public static int Min(int a, int b) { }

	public static float Min(float a, float b) { }

	[FreeFunction(IsThreadSafe = True)]
	public static int NextPowerOfTwo(int value) { }

	public static float Pow(float f, float p) { }

	public static float Repeat(float t, float length) { }

	public static float Round(float f) { }

	internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference) { }

	public static int RoundToInt(float f) { }

	public static float Sign(float f) { }

	public static float Sin(float f) { }

	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	public static float Sqrt(float f) { }

	public static float Tan(float f) { }

}

