//Type is in global namespace

public class Hotkey
{
	public MainItem itemcur; //Field offset: 0x10
	public MainSkill skill; //Field offset: 0x18

	public Hotkey() { }

	public static void checkUpdatePotion(MainItem itemcheck) { }

	public int getIndexDelay() { }

	public sbyte getTypeHotKey() { }

	public void paint(mGraphics g, int x, int y, int w) { }

	public void setPotion(MainItem item) { }

	public void setSkill(MainSkill skill, short IdIcon) { }

}

