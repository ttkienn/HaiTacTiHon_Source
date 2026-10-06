//Type is in global namespace

public class ScreenJoinItem : MainScreen
{
	public static ScreenJoinItem instance; //Field offset: 0x0
	private MainItem[] mItem; //Field offset: 0x50
	private int hItem; //Field offset: 0x58
	private Int32[][] posItem; //Field offset: 0x60
	private InputDialog input; //Field offset: 0x68
	private mVector cmdList; //Field offset: 0x70
	private mVector vecEff; //Field offset: 0x78
	private iCommand cmdClose; //Field offset: 0x80
	private iCommand cmdOk; //Field offset: 0x88
	private iCommand cmdInputNum; //Field offset: 0x90
	private iCommand cmdAgain; //Field offset: 0x98
	private int wDia; //Field offset: 0xA0
	private int wItem; //Field offset: 0xA4
	private int hDia; //Field offset: 0xA8
	private int xDia; //Field offset: 0xAC
	private int yDia; //Field offset: 0xB0
	private int idCommand; //Field offset: 0xB4
	private String[] strinfo; //Field offset: 0xB8
	public short numJoin; //Field offset: 0xC0
	private int Step; //Field offset: 0xC4
	private int tickStep; //Field offset: 0xC8
	private int tickStop; //Field offset: 0xCC

	public ScreenJoinItem() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual bool keyBack() { }

	public virtual void paint(mGraphics g) { }

	public void setInfoJoin(string info, MainItem[] mItem) { }

	public void setItemJoin(MainItem item, sbyte ishardcode) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

	private void updateStep() { }

}

