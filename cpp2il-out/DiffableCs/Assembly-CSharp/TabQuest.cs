//Type is in global namespace

public class TabQuest : MainTab
{
	public static iCommand cmdShow; //Field offset: 0x0
	public static bool isNewQuest; //Field offset: 0x8
	private ListNew list; //Field offset: 0x88
	private MainQuest questCur; //Field offset: 0x90
	private MarqueeText marName; //Field offset: 0x98
	private MarqueeText marInfo; //Field offset: 0xA0
	private Scroll scrQuest; //Field offset: 0xA8
	private int maxPaint; //Field offset: 0xB0

	public TabQuest(string name) { }

	public virtual void beginFocus() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void getQuestCur(int id) { }

	private void initCmd() { }

	public virtual void paint(mGraphics g) { }

	public void setClip(mGraphics g) { }

	public void showDialogQuest() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

