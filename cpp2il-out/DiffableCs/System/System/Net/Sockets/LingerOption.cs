namespace System.Net.Sockets;

public class LingerOption
{
	private bool enabled; //Field offset: 0x10
	private int lingerTime; //Field offset: 0x14

	public bool Enabled
	{
		 set { } //Length: 4
	}

	public int LingerTime
	{
		 set { } //Length: 4
	}

	public LingerOption(bool enable, int seconds) { }

	public void set_Enabled(bool value) { }

	public void set_LingerTime(int value) { }

}

