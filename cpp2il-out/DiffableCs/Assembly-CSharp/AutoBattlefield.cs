//Type is in global namespace

public class AutoBattlefield : MainObject
{
	public static bool isFar; //Field offset: 0x0
	public static int dFocus; //Field offset: 0x4
	public static bool isChangeFocus; //Field offset: 0x8
	public static bool isGoBack; //Field offset: 0x9
	public static bool isComeTarget; //Field offset: 0xA

	private static AutoBattlefield() { }

	public AutoBattlefield() { }

	public static void CheckMapAutoBattlefield() { }

	public static bool checkMapPb() { }

	public static MainObject findEnemyFocus() { }

	public static MainObject findEnemyFocusFar() { }

	public static bool movePlayer(int toX, int toY) { }

	public static void StartAutoBattlefield() { }

	public static void StopAutoBattlefield() { }

}

