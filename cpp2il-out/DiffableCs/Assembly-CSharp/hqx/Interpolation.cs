namespace hqx;

public class Interpolation
{
	private const uint Mask4 = 4278190080; //Field offset: 0x0
	private const uint Mask2 = 65280; //Field offset: 0x0
	private const uint Mask13 = 16711935; //Field offset: 0x0

	public Interpolation() { }

	public static int Mix14To1To1(int c1, int c2, int c3) { }

	public static int Mix2To1To1(int c1, int c2, int c3) { }

	public static int Mix2To3To3(int c1, int c2, int c3) { }

	public static int Mix2To7To7(int c1, int c2, int c3) { }

	public static int Mix3To1(int c1, int c2) { }

	public static int Mix4To2To1(int c1, int c2, int c3) { }

	public static int Mix5To3(int c1, int c2) { }

	public static int Mix6To1To1(int c1, int c2, int c3) { }

	public static int Mix7To1(int c1, int c2) { }

	public static int MixEven(int c1, int c2) { }

}

