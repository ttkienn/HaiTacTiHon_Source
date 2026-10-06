namespace hqx;

public abstract class Hqx
{
	private static int Ymask; //Field offset: 0x0
	private static int Umask; //Field offset: 0x4
	private static int Vmask; //Field offset: 0x8

	private static Hqx() { }

	protected Hqx() { }

	protected static bool diff(int c1, int c2, int trY, int trU, int trV, int trA) { }

	public static Int32[] HqxZoom(int zoom, Int32[] source, int Xres, int Yres) { }

}

