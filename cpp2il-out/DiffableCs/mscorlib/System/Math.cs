namespace System;

public static class Math
{
	private static double doubleRoundLimit; //Field offset: 0x0
	private static Double[] roundPower10Double; //Field offset: 0x8

	private static Math() { }

	public static float Abs(float value) { }

	public static double Abs(double value) { }

	public static int Abs(int value) { }

	public static decimal Abs(decimal value) { }

	public static long Abs(long value) { }

	public static double Acos(double d) { }

	public static double Atan(double d) { }

	public static double Atan2(double y, double x) { }

	public static double Ceiling(double a) { }

	public static int Clamp(int value, int min, int max) { }

	public static double Cos(double d) { }

	public static int DivRem(int a, int b, out int result) { }

	public static double Floor(double d) { }

	public static double Log(double d) { }

	public static double Log(double a, double newBase) { }

	public static double Log10(double d) { }

	[CLSCompliant(False)]
	[NonVersionable]
	public static sbyte Max(sbyte val1, sbyte val2) { }

	public static float Max(float val1, float val2) { }

	[NonVersionable]
	public static int Max(int val1, int val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	public static uint Max(uint val1, uint val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	public static ulong Max(ulong val1, ulong val2) { }

	[NonVersionable]
	public static short Max(short val1, short val2) { }

	public static double Max(double val1, double val2) { }

	public static decimal Max(decimal val1, decimal val2) { }

	[NonVersionable]
	public static byte Max(byte val1, byte val2) { }

	[NonVersionable]
	public static long Max(long val1, long val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	public static ushort Max(ushort val1, ushort val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	public static ulong Min(ulong val1, ulong val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	public static sbyte Min(sbyte val1, sbyte val2) { }

	[NonVersionable]
	public static byte Min(byte val1, byte val2) { }

	public static decimal Min(decimal val1, decimal val2) { }

	public static double Min(double val1, double val2) { }

	[NonVersionable]
	public static short Min(short val1, short val2) { }

	[NonVersionable]
	public static int Min(int val1, int val2) { }

	[NonVersionable]
	public static long Min(long val1, long val2) { }

	public static float Min(float val1, float val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	public static uint Min(uint val1, uint val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	public static ushort Min(ushort val1, ushort val2) { }

	private static double ModF(double x, Double* intptr) { }

	public static double Pow(double x, double y) { }

	public static double Round(double value, int digits, MidpointRounding mode) { }

	public static double Round(double value, int digits) { }

	public static double Round(double a) { }

	public static decimal Round(decimal d) { }

	public static int Sign(long value) { }

	public static int Sign(double value) { }

	public static double Sin(double a) { }

	public static double Sqrt(double d) { }

	public static double Tan(double a) { }

	[StackTraceHidden]
	private static void ThrowAbsOverflow() { }

	private static void ThrowMinMaxException(T min, T max) { }

	public static double Truncate(double d) { }

	public static decimal Truncate(decimal d) { }

}

