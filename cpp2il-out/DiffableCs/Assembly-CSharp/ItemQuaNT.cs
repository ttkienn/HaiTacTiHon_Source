//Type is in global namespace

public class ItemQuaNT : MainItem
{
	private int sizeItem; //Field offset: 0xC8
	public String[] strShow; //Field offset: 0xD0
	public int priceDauGia; //Field offset: 0xD8
	public int timeRemain; //Field offset: 0xDC
	public int giaChot; //Field offset: 0xE0

	public ItemQuaNT(string name, sbyte cat, short id, short num, sbyte color) { }

	public virtual void paint(mGraphics g, int x, int y, int w) { }

	public void paintInfo(mGraphics g, int x, int y) { }

	public void setDauGia(int money, int time, int giaChot) { }

}

