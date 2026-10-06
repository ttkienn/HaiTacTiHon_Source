//Type is in global namespace

public class MainScreen : AvMain
{
	public static Camera cameraMain; //Field offset: 0x0
	public static Camera cameraSub; //Field offset: 0x8
	private MainScreen mainScreen; //Field offset: 0x40
	public MainScreen lastScreen; //Field offset: 0x48

	public MainScreen() { }

	public void CheckClickCmd() { }

	public override bool keyBack() { }

	public override void keyPress(int keyCode) { }

	public virtual void paint(mGraphics g) { }

	public bool setCurTypetab(sbyte type) { }

	public void setTypeTab(sbyte type) { }

	public override void setxyPlus12() { }

	public override void Show() { }

	public override void Show(MainScreen screen) { }

	public virtual void update() { }

}

