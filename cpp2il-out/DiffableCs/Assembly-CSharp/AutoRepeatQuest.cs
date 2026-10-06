//Type is in global namespace

public class AutoRepeatQuest : MainObject
{
	[CompilerGenerated]
	private sealed class <StepDelay>d__55 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		private int <timeSpeedUp1>5__2; //Field offset: 0x20
		private int <timeSpeedUp2>5__3; //Field offset: 0x24
		private int <timeSpeedUp3>5__4; //Field offset: 0x28
		private int <timeSpeedUp4>5__5; //Field offset: 0x2C
		private int <timeSpeedUp5>5__6; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <StepDelay>d__55(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public const int dFocus = 140; //Field offset: 0x0
	public const int timeStep1 = 1000; //Field offset: 0x0
	public const int timeStep2 = 2000; //Field offset: 0x0
	public const int timeStep3 = 3000; //Field offset: 0x0
	public const int timeStep4 = 5000; //Field offset: 0x0
	public const int timeStep5 = 10000; //Field offset: 0x0
	public static int step; //Field offset: 0x0
	public const int xMove = 500; //Field offset: 0x0
	public const int yMove = 60; //Field offset: 0x0
	public static int toXDefault; //Field offset: 0x4
	public static int toYDefault; //Field offset: 0x8
	public static bool isCheckFinish; //Field offset: 0xC
	public static bool isStart; //Field offset: 0xD
	public static bool isComeMonster; //Field offset: 0xE
	public static bool isWaitingForMons; //Field offset: 0xF
	public static bool isGoBack; //Field offset: 0x10
	public static bool isFar; //Field offset: 0x11
	public static bool isFindMons; //Field offset: 0x12
	public static MainObject objectFocus; //Field offset: 0x18
	public int timeStep; //Field offset: 0x468
	public bool isCome; //Field offset: 0x46C
	private string nameMonQuest; //Field offset: 0x470
	private int timeSpeedUp1; //Field offset: 0x478
	private int timeSpeedUp2; //Field offset: 0x47C
	private int timeSpeedUp3; //Field offset: 0x480
	private int timeSpeedUp4; //Field offset: 0x484
	private int timeSpeedUp5; //Field offset: 0x488

	private static AutoRepeatQuest() { }

	public AutoRepeatQuest() { }

	public void beforeGetQuest() { }

	public bool checkBreadForQuest() { }

	public void checkFinishProcess() { }

	public bool checkFullItem() { }

	public static int checkGetQuest() { }

	public bool checkShowGift() { }

	public static bool fBeginAuto() { }

	public MainObject findMonster() { }

	public MainObject findMonsterFocus(MainQuest quest) { }

	public MainObject findMonsterFocusFar(MainQuest quest) { }

	public MainObject findTheQuestBoard() { }

	public static int getFocusTheQuestBoard() { }

	public string getNameMonsterRepeatQuest(MainQuest quest) { }

	public static MainQuest getRepeatCurrentQuest() { }

	public static MainQuest getRepeatQuest() { }

	public MainQuest getRepeatQuestFinsh() { }

	public int getStatusRepeatQuest() { }

	public static MainObject getTheQuestBoard() { }

	public static bool movePlayer(int toX, int toY) { }

	public void moveToQuestBoard() { }

	public void nextStep(MainQuest repeatQuest) { }

	public void runNextStep() { }

	public void startAuto() { }

	public void StartAutoRepeatQuest() { }

	public static void step1() { }

	public static void step2() { }

	public static void step3() { }

	public static void step4() { }

	public static void step5() { }

	[IteratorStateMachine(typeof(<StepDelay>d__55))]
	public static IEnumerator StepDelay() { }

	public static void stopAuto() { }

}

