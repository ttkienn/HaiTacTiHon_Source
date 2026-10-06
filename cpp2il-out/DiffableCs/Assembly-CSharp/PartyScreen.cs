//Type is in global namespace

public class PartyScreen : PaintListScreen
{
	public static PartyScreen instance; //Field offset: 0x0
	private iCommand cmdRemoveMem; //Field offset: 0x100
	private iCommand cmdLeave; //Field offset: 0x108
	private iCommand cmdCancelParty; //Field offset: 0x110
	private iCommand cmdChatParty; //Field offset: 0x118
	private iCommand cmdInfoBuffParty; //Field offset: 0x120

	public PartyScreen(sbyte type, mVector vec) { }

	public virtual void beginShow() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void doMenu() { }

	public virtual void doMenuTouchPlayer() { }

	public static PartyScreen gI() { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

	public virtual void update() { }

}

