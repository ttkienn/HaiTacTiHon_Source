namespace System.Globalization;

internal class Bootstring
{
	private readonly char delimiter; //Field offset: 0x10
	private readonly int base_num; //Field offset: 0x14
	private readonly int tmin; //Field offset: 0x18
	private readonly int tmax; //Field offset: 0x1C
	private readonly int skew; //Field offset: 0x20
	private readonly int damp; //Field offset: 0x24
	private readonly int initial_bias; //Field offset: 0x28
	private readonly int initial_n; //Field offset: 0x2C

	public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	private int Adapt(int delta, int numPoints, bool firstTime) { }

	public string Decode(string s, int offset) { }

	private int DecodeDigit(char c) { }

	public string Encode(string s, int offset) { }

	private char EncodeDigit(int d) { }

}

