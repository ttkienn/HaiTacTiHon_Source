//Type is in global namespace

public class MsgDialogEvent : MsgDialog
{
	private Int32[][] mpos; //Field offset: 0x138
	private Int32[] mvalueCM; //Field offset: 0x140
	private iCommand cmdTrangTri; //Field offset: 0x148
	private iCommand cmdDoiQua; //Field offset: 0x150
	private bool isFullEventCM; //Field offset: 0x158

	public MsgDialogEvent() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public void setInfoMerryCM() { }

	public virtual void update() { }

	public void updateDataCM(SByte[] mvalue) { }

}

