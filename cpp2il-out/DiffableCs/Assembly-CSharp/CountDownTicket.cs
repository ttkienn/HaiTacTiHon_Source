//Type is in global namespace

public class CountDownTicket
{
	public int timeCountDown; //Field offset: 0x10
	public long tickBeginCount; //Field offset: 0x18
	public string strInfo; //Field offset: 0x20
	public sbyte typeTime; //Field offset: 0x28
	public int valueLeft; //Field offset: 0x2C
	public int valueright; //Field offset: 0x30

	public CountDownTicket() { }

	public int CheckUpdate() { }

	public void paintCountDownTicket(mGraphics g, mFont f, int x, int y, int anchor) { }

	public void paintCountDownTicketHour(mGraphics g, mFont f, int x, int y, int anchor) { }

	public void setCountDown(int time) { }

	public static string timeShow(int time) { }

	public void updateTimeCountDownTicket() { }

}

