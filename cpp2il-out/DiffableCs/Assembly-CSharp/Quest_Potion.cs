//Type is in global namespace

public class Quest_Potion : MainItem
{

	public Quest_Potion(sbyte typeItem, short ID, string name) { }

	public virtual void addInfo(string str, sbyte color, sbyte colorMain) { }

	public virtual MainImage getImage() { }

	public virtual void paint(mGraphics g, int x, int y, int w) { }

}

