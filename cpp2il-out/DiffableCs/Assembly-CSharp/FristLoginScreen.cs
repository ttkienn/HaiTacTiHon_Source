//Type is in global namespace

public class FristLoginScreen : MainScreen
{
	public static string userNew; //Field offset: 0x0
	public static InputDialog input; //Field offset: 0x8
	public static iCommand cmdRegister; //Field offset: 0x10
	public iCommand cmdBegin; //Field offset: 0x50
	public iCommand cmdChangeAcc; //Field offset: 0x58
	public iCommand cmdServer; //Field offset: 0x60
	public iCommand cmdNewGame; //Field offset: 0x68
	private mVector vecCmd; //Field offset: 0x70
	private int valueBegin; //Field offset: 0x78
	private int idCommand; //Field offset: 0x7C

	private static FristLoginScreen() { }

	public FristLoginScreen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void getVecBegin() { }

	public virtual void paint(mGraphics g) { }

	public void setBeginGame() { }

	public void setNewAcc(bool isCheckDataOK) { }

	public virtual void setxyPlus12() { }

	public virtual void Show() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

