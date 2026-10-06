//Type is in global namespace

public class TabChest : MainTabShop
{
	public static iCommand cmdRemove; //Field offset: 0x0
	public static iCommand cmdGetItem; //Field offset: 0x8
	public static iCommand cmdGetPotion; //Field offset: 0x10
	public static iCommand cmdGetAllMaterial; //Field offset: 0x18
	public static iCommand cmdUpgrade; //Field offset: 0x20
	public static iCommand cmdChucnang; //Field offset: 0x28
	public static iCommand cmdGetAllDiamond; //Field offset: 0x30

	public TabChest(string name, mVector vec, int xTab) { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual mVector getMenuActionItem() { }

	public void initCmd() { }

	public virtual iCommand setCmdEndInfo() { }

}

