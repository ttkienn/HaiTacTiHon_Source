//Type is in global namespace

public class PopupChat : AvMain
{
	public const sbyte E_ITEM = 2; //Field offset: 0x0
	public static mImage[] mPopup; //Field offset: 0x0
	public const sbyte E_EMOTION = 1; //Field offset: 0x0
	public const sbyte E_NONE = 0; //Field offset: 0x0
	private int x; //Field offset: 0x40
	private int y; //Field offset: 0x44
	private int dy; //Field offset: 0x48
	public int h; //Field offset: 0x4C
	public int w; //Field offset: 0x50
	public int timeOff; //Field offset: 0x54
	public int indexpaint; //Field offset: 0x58
	public short idEmotion; //Field offset: 0x5C
	public String[] strChat; //Field offset: 0x60
	private bool isStop; //Field offset: 0x68
	private sbyte isEmotion; //Field offset: 0x69
	private MainItem item; //Field offset: 0x70
	private Int32[] color; //Field offset: 0x78

	private static PopupChat() { }

	public PopupChat() { }

	public virtual void paint(mGraphics g) { }

	public void paintPopup(mGraphics g) { }

	public void setChat(string strContent, bool isStop) { }

	public void setChat(short id) { }

	public void setChatItem(short id, sbyte cat, short num) { }

	public bool setOff() { }

	public void updatePos(int x, int y) { }

}

