//Type is in global namespace

public class MainDialog : AvMain
{
	public int wDia; //Field offset: 0x40
	public int hDia; //Field offset: 0x44
	public int xDia; //Field offset: 0x48
	public int yDia; //Field offset: 0x4C
	public int numw; //Field offset: 0x50
	public int numh; //Field offset: 0x54
	public int type; //Field offset: 0x58
	public String[] strinfo; //Field offset: 0x60
	public bool isBack; //Field offset: 0x68

	public MainDialog() { }

	public override void keypress(int keyCode) { }

}

