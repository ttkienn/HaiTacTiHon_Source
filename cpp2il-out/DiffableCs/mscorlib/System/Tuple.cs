namespace System;

public static class Tuple
{

	internal static int CombineHashCodes(int h1, int h2) { }

	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	public static Tuple<T1, T2> Create(T1 item1, T2 item2) { }

	public static Tuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3) { }

}

