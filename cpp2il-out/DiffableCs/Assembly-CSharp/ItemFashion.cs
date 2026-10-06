//Type is in global namespace

public class ItemFashion : MainItem
{

	public ItemFashion(short ID, short IDIcon, string name, string info, Int16[] wear) { }

	public virtual mVector getActionShop(sbyte typeShop) { }

	public virtual void paint(mGraphics g, int x, int y, int w) { }

}

