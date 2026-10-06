//Type is in global namespace

public class ChatTabScreen : MainScreen
{
	public const sbyte NEW = 0; //Field offset: 0x0
	public const sbyte UPDATE = 1; //Field offset: 0x0
	public int x; //Field offset: 0x50
	public int y; //Field offset: 0x54
	public int w; //Field offset: 0x58
	public int h; //Field offset: 0x5C
	public int miniItem; //Field offset: 0x60
	public int xBe; //Field offset: 0x64
	public int yBe; //Field offset: 0x68
	public int wCon; //Field offset: 0x6C
	public int hCon; //Field offset: 0x70
	public int wItem; //Field offset: 0x74
	public int hChat; //Field offset: 0x78
	public int wPaintTab; //Field offset: 0x7C
	public mVector vecTabChat; //Field offset: 0x80
	public ChatDetail tabCur; //Field offset: 0x88
	public int idSelect; //Field offset: 0x90
	private ListNew CamDetailChat; //Field offset: 0x98
	private ListNew CamTab; //Field offset: 0xA0
	private iCommand cmdMenu; //Field offset: 0xA8
	private iCommand cmdCloseChat; //Field offset: 0xB0
	private iCommand cmdCloseTab; //Field offset: 0xB8
	private iCommand cmdChat; //Field offset: 0xC0
	private int minChat; //Field offset: 0xC8
	private int maxChat; //Field offset: 0xCC

	public ChatTabScreen() { }

	public void addNewChat(string name, string FristContent, string content, sbyte type, bool isFocus, int color) { }

	public void addNewChat(string name, string FristContent, string content, sbyte type, bool isFocus) { }

	public void addNewChatCheckSpam(string name, string FristContent, string content, sbyte type, bool isFocus) { }

	private void checkRemove() { }

	public void checkRemoveTab(string name) { }

	public virtual void commandPointer(int index, int subIndex) { }

	private void doMenu() { }

	public override void getCurTab(int id) { }

	public void getRightCmd() { }

	public virtual bool keyBack() { }

	public virtual void keyPress(int keyCode) { }

	public virtual void paint(mGraphics g) { }

	public void set_text_min_max() { }

	public virtual void setxyPlus12() { }

	public virtual void Show(MainScreen screen) { }

	public virtual void update() { }

	public void updateCameraNew(int size, sbyte type) { }

	public void updateCamTab() { }

	public void updateCmd() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

