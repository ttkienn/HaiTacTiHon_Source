namespace Assets.src.JavaCode.Map;

public class MapLayer
{
	private mImage image; //Field offset: 0x10
	private double scrollSpeedFactor; //Field offset: 0x18
	private int width; //Field offset: 0x20
	private int height; //Field offset: 0x24
	private int screenHeight; //Field offset: 0x28
	private bool isFarBackground; //Field offset: 0x2C

	public MapLayer(mImage image, double scrollSpeedFactor, int width, int height, int screenHeight, bool isFarBackground) { }

	public void draw(mGraphics g, int cameraOffsetX, int screenWidth) { }

}

