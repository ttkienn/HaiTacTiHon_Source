//Type is in global namespace

public class ItemInfo : SubScreen
{
	public static ItemInfo instance; //Field offset: 0x0
	private InfoMemList mem; //Field offset: 0x70
	private iCommand cmdClose; //Field offset: 0x78
	private mVector vecMenu; //Field offset: 0x80
	private int idCommand; //Field offset: 0x88

	public ItemInfo(sbyte type, InfoMemList mem) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void paint(mGraphics g) { }

	private void paintInfo(mGraphics g) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

