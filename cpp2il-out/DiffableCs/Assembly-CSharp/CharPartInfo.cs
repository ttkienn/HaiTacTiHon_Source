//Type is in global namespace

public class CharPartInfo
{
	public static mPart[] parts; //Field offset: 0x0
	public static MyHashTable hashMyPart; //Field offset: 0x8

	private static CharPartInfo() { }

	public CharPartInfo() { }

	public static void checkDelHashCharPart(MyHashTable hash, int time) { }

	public static mPart getPart(int index) { }

	public static void LoadDataCharPart(DataInputStream dis, int isSave) { }

	public static void loadImage(DataInputStream dis, int sizeImage) { }

	public static void loadPart(DataInputStream dis, int sizePart) { }

	public static void readPart(SByte[] data) { }

}

