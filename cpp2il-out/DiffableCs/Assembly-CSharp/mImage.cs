//Type is in global namespace

public class mImage
{
	public Image image; //Field offset: 0x10
	public int w; //Field offset: 0x18
	public int h; //Field offset: 0x1C

	public mImage() { }

	public static mImage createImage(string url) { }

	public static mImage createImage(int w, int h) { }

	public static mImage createImage(SByte[] data, int w, int h) { }

	public static mImage createImageAll(string url) { }

	public static mImage createRGBImage(Int32[] rgb, int width, int height, bool processAlpha) { }

	public TemGraphics getGraphics() { }

	public static int getImageHeight(Image image) { }

	public static int getImageWidth(Image image) { }

	public static string getLink(string str) { }

	public void getRGB(Int32[] rgbData, int offset, int scanlength, int x, int y, int width, int height) { }

	public static string getUrlImage(string str) { }

	public static mImage scaleImage(mImage img, int w, int h) { }

	public void setWH() { }

}

