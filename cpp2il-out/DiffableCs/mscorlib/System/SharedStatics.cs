namespace System;

internal sealed class SharedStatics
{
	private static readonly SharedStatics _sharedStatics; //Field offset: 0x0
	private StringMaker _maker; //Field offset: 0x10

	private static SharedStatics() { }

	private SharedStatics() { }

	public static StringMaker GetSharedStringMaker() { }

	public static void ReleaseSharedStringMaker(ref StringMaker maker) { }

}

