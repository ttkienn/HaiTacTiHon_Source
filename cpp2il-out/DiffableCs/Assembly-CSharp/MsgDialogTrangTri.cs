//Type is in global namespace

public class MsgDialogTrangTri : MsgDialog
{
	public static sbyte TT_BANH_TET; //Field offset: 0x0
	public static sbyte TT_LO_SUOI; //Field offset: 0x1
	private sbyte typeTrangTri; //Field offset: 0x138
	private Int16[][] mpos; //Field offset: 0x140
	private SByte[] mSoLuong; //Field offset: 0x148
	private iCommand cmdTrangTri; //Field offset: 0x150
	private iCommand cmdDoiQua; //Field offset: 0x158
	private bool isFullEvent; //Field offset: 0x160
	private mVector meff; //Field offset: 0x168

	private static MsgDialogTrangTri() { }

	public MsgDialogTrangTri() { }

	public MsgDialogTrangTri(sbyte typeTrangTri) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void setInfoTrangTri(Int16[][] mpos) { }

	public virtual void update() { }

	public void updateDataTrangTri(Int16[] mId, SByte[] mvalue) { }

}

