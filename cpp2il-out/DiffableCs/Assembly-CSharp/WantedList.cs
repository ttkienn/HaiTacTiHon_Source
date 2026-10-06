//Type is in global namespace

public class WantedList : PaintListScreen
{
	public const sbyte TYPE_SEND_REFESH = 0; //Field offset: 0x0
	public const sbyte ACTION_REMOVE = 3; //Field offset: 0x0
	public const sbyte ACTION_NHAN_THUONG = 2; //Field offset: 0x0
	public const sbyte ACTION_CANCEL = 1; //Field offset: 0x0
	public const sbyte ACTION_VIEW = 0; //Field offset: 0x0
	public static WantedList instance; //Field offset: 0x0
	public const sbyte TYPE_VIEW_LIST_DA_NHAN = 4; //Field offset: 0x0
	public const sbyte TYPE_VIEW_LIST_PHAT_LENH = 3; //Field offset: 0x0
	public const sbyte TYPE_NHAN = 2; //Field offset: 0x0
	public const sbyte TYPE_VIEW_INFO = 1; //Field offset: 0x0
	public const sbyte TYPE_VIEW_INFO_PHAT_LENH = 5; //Field offset: 0x0
	private iCommand cmdNext; //Field offset: 0x100
	private iCommand cmdPre; //Field offset: 0x108
	private iCommand cmdDs; //Field offset: 0x110
	private iCommand cmdPhat; //Field offset: 0x118
	private iCommand cmdNhan; //Field offset: 0x120
	private mVector vecCmd; //Field offset: 0x128
	private sbyte page; //Field offset: 0x130
	private int countPage; //Field offset: 0x134
	private int listSize; //Field offset: 0x138
	private int wDsCmd; //Field offset: 0x13C
	private int idDsCmdSelected; //Field offset: 0x140

	public WantedList(sbyte type, mVector vec) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void doMenu() { }

	public virtual void doMenuTouchPlayer() { }

	public virtual void paint(mGraphics g) { }

	public virtual void paintBg(mGraphics g) { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

	public virtual void paintSelect(mGraphics g, int xbegin, int ybegin, int wFocus) { }

	public virtual void setCamera() { }

	private void setDsCmdSelected() { }

	private void SetIdListCmdSelect() { }

	private void SetListSize() { }

	public virtual void setPosCmdNew(int yplus, mVector vecMenu) { }

	private void setPosDsCmd(int xbegin, int ybegin) { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

