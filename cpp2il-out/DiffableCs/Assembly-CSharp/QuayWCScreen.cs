//Type is in global namespace

public class QuayWCScreen : LuckyScreen
{
	public static QuayWCScreen instance; //Field offset: 0x0
	public short idIconVongQuay; //Field offset: 0x110
	public short numLanDaQuay; //Field offset: 0x112
	public short numVe; //Field offset: 0x114

	public QuayWCScreen() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public void loadIconVongQuay() { }

	public virtual void loadImgVongQuay() { }

	public virtual void paint(mGraphics g) { }

	public virtual void setPosPotion() { }

	public virtual int updateNumve() { }

}

