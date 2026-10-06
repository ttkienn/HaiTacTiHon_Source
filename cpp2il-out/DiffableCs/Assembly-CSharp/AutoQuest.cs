//Type is in global namespace

public class AutoQuest
{
	public static bool AC_AUTO_QUEST; //Field offset: 0x0
	public const sbyte STATUS_BEGIN = 0; //Field offset: 0x0
	public const sbyte STATUS_CHAT = 1; //Field offset: 0x0
	public const sbyte STATUS_CURRENT = 2; //Field offset: 0x0
	public const sbyte STATUS_MOVE = 3; //Field offset: 0x0
	public const sbyte STATUS_WAIT = 4; //Field offset: 0x0
	public static sbyte STATUS_AQ; //Field offset: 0x1
	private static bool atNPC; //Field offset: 0x2
	private static bool atCenter; //Field offset: 0x3
	private static bool isMove; //Field offset: 0x4
	private static MainQuest mAutoQuest; //Field offset: 0x8
	public static MainObject objNPC; //Field offset: 0x10
	public static mVector vecAutoQuest; //Field offset: 0x18
	public static sbyte numFireBoss; //Field offset: 0x20
	public static sbyte iPhanTu; //Field offset: 0x21
	public static short idMonster; //Field offset: 0x22
	public static short idBoss; //Field offset: 0x24
	private static Timer timerRun1; //Field offset: 0x28
	private static Timer timerRun2; //Field offset: 0x30
	private static Timer timerRun3; //Field offset: 0x38
	private static Timer timerRun4; //Field offset: 0x40
	private static Timer timerRun5; //Field offset: 0x48
	private static Timer timerRun6; //Field offset: 0x50
	private static Timer timerRunEnd; //Field offset: 0x58
	private static int endTimerRun; //Field offset: 0x60

	private static AutoQuest() { }

	public AutoQuest() { }

	private static void begin() { }

	public static void changeAcAutoQuest() { }

	private static void chatQuest() { }

	private static bool checkBreak() { }

	public static void checkFireBoss() { }

	public static void checkQuestFinishAQ() { }

	private static bool checkQuestLoopCurrentInMap() { }

	private static bool checkQuestLoopNotInMap() { }

	private static bool checkQuestLoopNPC() { }

	public static void continueAutoQuest() { }

	public static MainObject getMonster() { }

	public static MainObject getMonsterByIndex(short index) { }

	private static MainObject getNPC() { }

	public static bool isQuestFinish() { }

	public static void moveCenter() { }

	public static void moveNPC() { }

	public static void movePlayerToCenter() { }

	public static void movePlayerToNPC() { }

	private static void onTimerRun1(object sender, ElapsedEventArgs e) { }

	private static void onTimerRun2(object sender, ElapsedEventArgs e) { }

	private static void onTimerRun3(object sender, ElapsedEventArgs e) { }

	private static void onTimerRun4(object sender, ElapsedEventArgs e) { }

	private static void onTimerRun5(object sender, ElapsedEventArgs e) { }

	private static void onTimerRun6(object sender, ElapsedEventArgs e) { }

	private static void onTimerRunEnd(object sender, ElapsedEventArgs e) { }

	public static void resetAutoQuest() { }

	private static void setIdMonBoss() { }

	public static void updateAutoQuest() { }

}

