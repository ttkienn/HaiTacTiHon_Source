namespace Mono.Security;

internal sealed class BitConverterLE
{

	internal static Byte[] GetBytes(int value) { }

	internal static Byte[] GetBytes(long value) { }

	private static Byte[] GetUIntBytes(Byte* bytes) { }

	private static Byte[] GetULongBytes(Byte* bytes) { }

	internal static int ToInt32(Byte[] value, int startIndex) { }

	internal static ushort ToUInt16(Byte[] value, int startIndex) { }

	internal static uint ToUInt32(Byte[] value, int startIndex) { }

	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	private static void UShortFromBytes(Byte* dst, Byte[] src, int startIndex) { }

}

