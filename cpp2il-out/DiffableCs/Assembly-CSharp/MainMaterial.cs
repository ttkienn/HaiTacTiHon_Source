//Type is in global namespace

public class MainMaterial : MainItem
{
	public const sbyte MATERIAL_UPGRADE = 0; //Field offset: 0x0
	public const sbyte MATERIAL_SPLIT = 1; //Field offset: 0x0
	public const sbyte MATERIAL_LUCKY = 2; //Field offset: 0x0
	public const sbyte MATERIAL_PROTECT = 3; //Field offset: 0x0
	public const sbyte MATERIAL_LUCKY_VIP = 4; //Field offset: 0x0
	public const sbyte MATERIAL_PROTECT_VER_2 = 7; //Field offset: 0x0

	public MainMaterial(sbyte Id, string name, sbyte type, sbyte idicon, int price, short priceRuby, sbyte isTrade) { }

	public MainMaterial(sbyte typeObj, sbyte Id, string name, sbyte type, sbyte idicon, short num, int price, short priceRuby, sbyte isTrade) { }

	public bool canSell() { }

	public virtual mVector getActionChest() { }

	public virtual mVector getActionInven(sbyte type) { }

	public virtual mVector getActionShop(sbyte typeShop) { }

	public virtual mVector getActionUpgrade() { }

	public virtual MainImage getImage() { }

	public void getInfo() { }

	public virtual bool getStar() { }

	public virtual void paint(mGraphics g, int x, int y, int w) { }

}

