//Type is in global namespace

public class Lazer : MainEffect
{
	private int angle0; //Field offset: 0x160
	private int lim; //Field offset: 0x164
	private int x; //Field offset: 0x168
	private int y; //Field offset: 0x16C
	private int xlim; //Field offset: 0x170
	private int ylim; //Field offset: 0x174
	private int xkc; //Field offset: 0x178
	private int ykc; //Field offset: 0x17C
	private int power; //Field offset: 0x180
	private int time; //Field offset: 0x184
	private int maxlim; //Field offset: 0x188
	private int idColor; //Field offset: 0x18C
	private sbyte type; //Field offset: 0x190
	private Int32[] color; //Field offset: 0x198

	public Lazer(sbyte type, int x, int y, int xTo, int yTo) { }

	public Lazer() { }

	public virtual void paint(mGraphics g) { }

	public virtual void removeEff() { }

	public virtual void update() { }

	public void update2() { }

}

