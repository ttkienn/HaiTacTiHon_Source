//Type is in global namespace

public class MyAudioClip
{
	public string name; //Field offset: 0x10
	public AudioClip clip; //Field offset: 0x18
	public long timeStart; //Field offset: 0x20

	public MyAudioClip(string filename) { }

	public bool isPlaying() { }

	public void Play() { }

}

