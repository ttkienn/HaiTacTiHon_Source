//Type is in global namespace

public class ItemBoat : MainItem
{

	public ItemBoat(short ID, short IDIcon, short IdImage, string name, sbyte type) { }

	public virtual mVector getActionShop(sbyte typeShop) { }

	public virtual MainImage getImage() { }

	public static void paintPartBoat(mGraphics g, short idImage, int type, int x, int y, int dy, int Dir) { }

}

