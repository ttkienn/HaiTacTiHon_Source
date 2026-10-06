//Type is in global namespace

public class MsgInfoMemSudo : MsgDialog
{
	private InfoMemList mem; //Field offset: 0x138
	private int sizeBanner; //Field offset: 0x140
	private iCommand cmdGiaoTiep; //Field offset: 0x148
	private iCommand cmdKick; //Field offset: 0x150
	private iCommand cmdPhongChuc; //Field offset: 0x158
	private iCommand cmdDonate; //Field offset: 0x160
	private iCommand cmdInfo; //Field offset: 0x168
	private iCommand cmdChat; //Field offset: 0x170
	private iCommand cmdAddFriend; //Field offset: 0x178
	private iCommand cmdLeave; //Field offset: 0x180
	private iCommand cmdGopRuby; //Field offset: 0x188
	private iCommand cmdInven; //Field offset: 0x190
	private iCommand cmdWorld; //Field offset: 0x198
	private iCommand cmdIconClan; //Field offset: 0x1A0
	private InputDialog input; //Field offset: 0x1A8

	public MsgInfoMemSudo(InfoMemList mem) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

