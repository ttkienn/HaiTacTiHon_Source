//Type is in global namespace

public class Camera
{
	public static Camera instance; //Field offset: 0x0
	public int xCam; //Field offset: 0x10
	public int yCam; //Field offset: 0x14
	public int xTo; //Field offset: 0x18
	public int yTo; //Field offset: 0x1C
	public int xLimit; //Field offset: 0x20
	public int yLimit; //Field offset: 0x24
	public long timeDelay; //Field offset: 0x28
	private int cmvx; //Field offset: 0x30
	private int cmdx; //Field offset: 0x34
	private int cmvy; //Field offset: 0x38
	private int cmdy; //Field offset: 0x3C

	public Camera() { }

	public void moveCamera(int xTo, int yTo) { }

	public void setAll(int xLimit, int yLimit, int xCam, int yCam) { }

	public void setAllTo(int xLimit, int yLimit, int xCam, int yCam) { }

	public void setCamera(int xCam, int yCam) { }

	public void setCameraWithLim(int xCam, int yCam, bool isRoom) { }

	public void UpdateCamera() { }

	public void UpdateCameraGameScreen() { }

}

