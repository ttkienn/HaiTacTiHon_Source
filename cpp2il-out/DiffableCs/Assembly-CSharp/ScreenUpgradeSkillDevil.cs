//Type is in global namespace

public class ScreenUpgradeSkillDevil : ScreenUpgrade
{
	public static ScreenUpgradeSkillDevil instance; //Field offset: 0x0
	private mVector vecSkill; //Field offset: 0x1D0
	private int wItemCur; //Field offset: 0x1D8
	private int miniItem; //Field offset: 0x1DC
	private MarqueeText marName; //Field offset: 0x1E0

	public ScreenUpgradeSkillDevil() { }

	public void begin() { }

	public virtual void commandPointer(int index, int subIndex) { }

	public virtual void getItemCurNew() { }

	public virtual void paint(mGraphics g) { }

	public void paintSelect(mGraphics g) { }

	private void paintSkill(mGraphics g) { }

	public virtual void paintTiLe(mGraphics g) { }

	public void setClip(mGraphics g) { }

	public virtual void setStep() { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updateNewUpgrade() { }

	public virtual void updatePointer() { }

}

