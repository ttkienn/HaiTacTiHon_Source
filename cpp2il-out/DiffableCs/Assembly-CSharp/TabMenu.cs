//Type is in global namespace

public class TabMenu : MainTab
{
	private Menu menu; //Field offset: 0x88

	public TabMenu(string name, mVector vecmenu) { }

	public virtual void beginFocus() { }

	private void initCmd() { }

	public virtual void paint(mGraphics g) { }

	public void paintLine(mGraphics g, int i) { }

	public virtual void update() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

