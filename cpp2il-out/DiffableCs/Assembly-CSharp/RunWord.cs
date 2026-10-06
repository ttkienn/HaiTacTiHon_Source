//Type is in global namespace

public class RunWord
{
	public bool showDlg; //Field offset: 0x10
	public int nStepToShow; //Field offset: 0x14
	public int currentDlgStep; //Field offset: 0x18
	public int dlgActionType; //Field offset: 0x1C
	public String[] dlgChainInfo; //Field offset: 0x20
	public int dlgFocusX; //Field offset: 0x28
	public int dlgFocusY; //Field offset: 0x2C
	public int dlgRunX; //Field offset: 0x30
	public int dlgRunY; //Field offset: 0x34
	public int dlgW; //Field offset: 0x38
	public int dlgX; //Field offset: 0x3C
	private mFont f; //Field offset: 0x40

	public RunWord() { }

	public bool checkDlgStep() { }

	public bool nextDlgStep() { }

	public void paintText(mGraphics g) { }

	public void paintText(mGraphics g, int archor) { }

	public void startDialogChain(string dlgChain, int ActionType, int xFocus, int yFocus, int w, mFont f) { }

	public void updateDlg() { }

}

