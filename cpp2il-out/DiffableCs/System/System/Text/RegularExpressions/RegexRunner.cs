namespace System.Text.RegularExpressions;

public abstract class RegexRunner
{
	private const int TimeoutCheckFrequency = 1000; //Field offset: 0x0
	protected private int runtextbeg; //Field offset: 0x10
	protected private int runtextend; //Field offset: 0x14
	protected private int runtextstart; //Field offset: 0x18
	protected private string runtext; //Field offset: 0x20
	protected private int runtextpos; //Field offset: 0x28
	protected private Int32[] runtrack; //Field offset: 0x30
	protected private int runtrackpos; //Field offset: 0x38
	protected private Int32[] runstack; //Field offset: 0x40
	protected private int runstackpos; //Field offset: 0x48
	protected private Int32[] runcrawl; //Field offset: 0x50
	protected private int runcrawlpos; //Field offset: 0x58
	protected private int runtrackcount; //Field offset: 0x5C
	protected private Match runmatch; //Field offset: 0x60
	protected private Regex runregex; //Field offset: 0x68
	private int _timeout; //Field offset: 0x70
	private bool _ignoreTimeout; //Field offset: 0x74
	private int _timeoutOccursAt; //Field offset: 0x78
	private int _timeoutChecksToSkip; //Field offset: 0x7C

	protected private RegexRunner() { }

	protected void Capture(int capnum, int start, int end) { }

	protected void CheckTimeout() { }

	protected void Crawl(int i) { }

	protected int Crawlpos() { }

	private void DoCheckTimeout() { }

	protected void DoubleCrawl() { }

	protected void DoubleStack() { }

	protected void DoubleTrack() { }

	protected void EnsureStorage() { }

	protected abstract bool FindFirstChar() { }

	protected abstract void Go() { }

	private void InitMatch() { }

	protected abstract void InitTrackCount() { }

	protected bool IsBoundary(int index, int startpos, int endpos) { }

	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	protected bool IsMatched(int cap) { }

	protected int MatchIndex(int cap) { }

	protected int MatchLength(int cap) { }

	protected int Popcrawl() { }

	protected private Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	private void StartTimeoutWatch() { }

	private Match TidyMatch(bool quick) { }

	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	protected void Uncapture() { }

}

