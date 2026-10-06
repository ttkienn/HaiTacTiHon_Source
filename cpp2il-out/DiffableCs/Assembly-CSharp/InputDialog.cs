//Type is in global namespace

public class InputDialog : MainDialog
{
	private static int hTouch; //Field offset: 0x0
	private static int istouchMore; //Field offset: 0x4
	public static iCommand cmdInputServer; //Field offset: 0x8
	public TField tfInput; //Field offset: 0x70
	private iCommand cmdClose; //Field offset: 0x78
	public TField[] mtfInput; //Field offset: 0x80
	private bool isMore; //Field offset: 0x88
	private bool isNew; //Field offset: 0x89
	private int price; //Field offset: 0x8C
	private string name; //Field offset: 0x90
	private string info; //Field offset: 0x98
	private string xuluong; //Field offset: 0xA0
	private String[] mStrNote; //Field offset: 0xA8
	public short IDInputserver; //Field offset: 0xB0
	private mFont fontInput; //Field offset: 0xB8
	private ListNew listnew; //Field offset: 0xC0
	private string strtam; //Field offset: 0xC8

	public InputDialog() { }

	public void closeDialog() { }

	public virtual void commandTab(int index, int subIndex) { }

	public virtual void keypress(int keyCode) { }

	public virtual void paint(mGraphics g) { }

	public void setinfo(string info, iCommand cmd, bool isNum, string nameInput) { }

	public void setinfo(String[] info, string name, short Id, iCommand cmd, string strNote) { }

	public void setinfoSmallNew(string info, iCommand cmd, bool isNum, int defValue, int price, string name, string xuluong) { }

	public void setNameDefaul(String[] str) { }

	public void settfNull(String[] strnull) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

