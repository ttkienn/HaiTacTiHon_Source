namespace Mono.Security;

internal sealed class BitConverterLE
{

	internal static Byte[] GetBytes(float value) { }

	internal static Byte[] GetBytes(double value) { }

	private static Byte[] GetUIntBytes(Byte* bytes) { }

	private static Byte[] GetULongBytes(Byte* bytes) { }

	internal static double ToDouble(Byte[] value, int startIndex) { }

	internal static float ToSingle(Byte[] value, int startIndex) { }

	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	private static void ULongFromBytes(Byte* dst, Byte[] src, int startIndex) { }

}

