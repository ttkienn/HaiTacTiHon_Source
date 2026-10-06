//Type is in global namespace

public class ChatTextField : AvMain
{
	public static ChatTextField instance; //Field offset: 0x0
	public static bool isShow; //Field offset: 0x8
	public TField tfChat; //Field offset: 0x40

	protected ChatTextField() { }

	public virtual void commandTab(int index, int subIndex) { }

	public static ChatTextField gI() { }

	public void init() { }

	public void keyPressed(int keyCode) { }

	public virtual void paint(mGraphics g) { }

	public void sendChat() { }

	public void setChat() { }

	public virtual void updatekey() { }

	public virtual void updatePointer() { }

}

