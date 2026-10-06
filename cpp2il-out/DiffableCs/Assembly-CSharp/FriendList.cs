//Type is in global namespace

public class FriendList : PaintListScreen
{
	public static bool isGetListFriend; //Field offset: 0x0
	public static FriendList instance; //Field offset: 0x8
	private iCommand cmdRemoveFriend; //Field offset: 0x100
	private iCommand cmdRefresh; //Field offset: 0x108

	public FriendList(sbyte type, mVector vec) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void doMenu() { }

	public virtual void doMenuTouchPlayer() { }

	public static FriendList gI() { }

	public virtual void paintInfo(mGraphics g, InfoMemList mem, int xpaint, int ypaint, int i, int wsub) { }

}

