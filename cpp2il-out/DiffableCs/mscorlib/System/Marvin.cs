namespace System;

internal static class Marvin
{
	[CompilerGenerated]
	private static readonly ulong <DefaultSeed>k__BackingField; //Field offset: 0x0

	public static ulong DefaultSeed
	{
		[CompilerGenerated]
		 get { } //Length: 78
	}

	private static uint _rotl(uint value, int shift) { }

	private static Marvin() { }

	private static void Block(ref uint rp0, ref uint rp1) { }

	public static int ComputeHash32(ReadOnlySpan<Byte> data, ulong seed) { }

	public static int ComputeHash32(ref byte data, int count, ulong seed) { }

	private static ulong GenerateSeed() { }

	[CompilerGenerated]
	public static ulong get_DefaultSeed() { }

}

