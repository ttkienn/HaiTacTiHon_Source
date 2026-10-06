//Type is in global namespace

public class DelaySkill
{
	public sbyte typeSkill; //Field offset: 0x10
	public long timebegin; //Field offset: 0x18
	public int value; //Field offset: 0x20
	public int limit; //Field offset: 0x24

	public DelaySkill() { }

	public static DelaySkill getDelay(int index) { }

	public bool isCoolDown() { }

	public void paint(mGraphics g, int x, int y, int w) { }

	public void paintOnlytime(mGraphics g, int x, int y, int w, sbyte color) { }

}

