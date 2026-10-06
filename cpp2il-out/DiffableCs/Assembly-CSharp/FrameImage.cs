//Type is in global namespace

public class FrameImage
{
	public int frameWidth; //Field offset: 0x10
	public int frameHeight; //Field offset: 0x14
	public int nFrame; //Field offset: 0x18
	public int maxNumFrame; //Field offset: 0x1C
	public int indexSuper; //Field offset: 0x20
	public mImage imgFrame; //Field offset: 0x28
	private int Id; //Field offset: 0x30
	private bool lowG; //Field offset: 0x34
	private bool isFormFrame; //Field offset: 0x35

	public FrameImage(mImage img, int width, int height) { }

	public FrameImage(int ID, int width, int height, int width2, int height2, int maxNumFrame) { }

	public FrameImage(int ID, int width, int height, sbyte maxNumFrame, sbyte frameSuper) { }

	public FrameImage(mImage img, int ID, int width, int height, int maxNumFrame) { }

	public FrameImage(int ID, int width, int height, int width2, int height2) { }

	public FrameImage(MainImage ImagePotion, int ID, int numframe) { }

	public FrameImage(int ID, int width, int height, int maxNumFrame) { }

	public FrameImage(mImage img, int numframe) { }

	public FrameImage(int ID, int width, int height) { }

	public FrameImage(mImage img, int width, int height, int maxNumFrame, sbyte frameSuper) { }

	public FrameImage(mImage img, int width, int height, int maxNumFrame) { }

	public FrameImage(int ID, int numframe) { }

	public void createFrameImgNew(int ID, int width, int height, int maxNumFrame) { }

	public void drawFrame(int idx, int x, int y, int trans, int orthor, mGraphics g) { }

	public void drawFrameNew(int idx, int x, int y, int trans, int orthor, mGraphics g) { }

	public void drawFrameNew_BeginSuper(int idx, int x, int y, int trans, int orthor, mGraphics g) { }

	public mImage getImage() { }

	public mImage getImageFrame() { }

}

