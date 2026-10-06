//Type is in global namespace

public class ItemHair : MainItem
{
	private sbyte typePart; //Field offset: 0xC8

	public ItemHair(short ID, short IDIcon, string name, sbyte typeObject) { }

	public virtual mVector getActionShop(sbyte typeShop) { }

	public virtual void paint(mGraphics g, int x, int y, int w) { }

}

