//Type is in global namespace

public class Other_Player : MainPlayer
{
	private mVector vecEffShip; //Field offset: 0x498

	public Other_Player(short ID, sbyte type, string name, int x, int y) { }

	public void getInfo() { }

	public virtual void Giaotiep() { }

	public virtual void paint(mGraphics g) { }

	public virtual void paintHideAvatar(mGraphics g) { }

	public void paintImgMonSter(mGraphics g) { }

	public virtual void paintOnlyShadown(mGraphics g) { }

	private void paintShadow(mGraphics g) { }

	public virtual void setFireObject(int value) { }

	public virtual void setImgMonSterforOtherPlayer(sbyte typeMove) { }

	public virtual void setTouchPoint() { }

	public virtual void update() { }

}

