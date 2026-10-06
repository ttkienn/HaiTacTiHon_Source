//Type is in global namespace

public class mSound
{
	private const int INTERVAL = 5; //Field offset: 0x0
	private const int MAXTIME = 100; //Field offset: 0x0
	public static int status; //Field offset: 0x0
	public static int postem; //Field offset: 0x4
	public static int timestart; //Field offset: 0x8
	private static string filenametemp; //Field offset: 0x10
	private static float volumetem; //Field offset: 0x18
	public static bool isSound; //Field offset: 0x1C
	public static bool isMusic; //Field offset: 0x1D
	public static bool isNotPlay; //Field offset: 0x1E
	public static AudioSource SoundWater; //Field offset: 0x20
	public static AudioSource SoundRun; //Field offset: 0x28
	public static AudioSource SoundBGLoop; //Field offset: 0x30
	public static float volumeSound; //Field offset: 0x38
	public static float volumeMusic; //Field offset: 0x3C
	public static AudioClip[] music; //Field offset: 0x40
	public static GameObject[] player; //Field offset: 0x48
	public static int l1; //Field offset: 0x50
	public static int idCurent; //Field offset: 0x54

	private static void __load(string filename, int pos) { }

	public static void __start(float volume, int pos) { }

	public static void __stop(int pos) { }

	private static void _load(string filename, int pos) { }

	public static void _start(float volume, int pos) { }

	public static void _stop(int pos) { }

	private static mSound() { }

	public mSound() { }

	public static void getAssetSoundFile(string fileName, int pos) { }

	public static void init(int musicID, int sID) { }

	public static void init() { }

	public static bool isPlaying() { }

	public static bool isPlayingSound() { }

	public static bool isPlayingSoundatural(int id) { }

	public static bool isPlayingSoundBG(int id) { }

	public static void load(string filename, int pos) { }

	public static void play(int id, float volume) { }

	public static void playMus(int type, float vl, bool loop) { }

	public static void playSound(int id, float volume) { }

	public static void playSound1(int id, float volume) { }

	public static void playSoundBGLoop(int id, float volume) { }

	public static void playSoundNatural(int id, float volume, bool isLoop) { }

	public static void playSoundRun(int id, float volume) { }

	public static void start(float volume, int pos) { }

	public static void stop(int pos) { }

	public static void stopAll() { }

	public static void stopAllBg() { }

	public static void stopAllz() { }

	public static void stopMusic(int x) { }

	public static void stopSoundAll() { }

	public static void sTopSoundBG(int id) { }

	public static void stopSoundNatural(int id) { }

	public static void sTopSoundRun() { }

	public static void update() { }

}

