namespace System.Timers;

[DefaultEvent("Elapsed")]
[DefaultProperty("Interval")]
public class Timer : Component
{
	private double interval; //Field offset: 0x28
	private bool enabled; //Field offset: 0x30
	private bool initializing; //Field offset: 0x31
	private bool delayedEnable; //Field offset: 0x32
	private ElapsedEventHandler onIntervalElapsed; //Field offset: 0x38
	private bool autoReset; //Field offset: 0x40
	private ISynchronizeInvoke synchronizingObject; //Field offset: 0x48
	private bool disposed; //Field offset: 0x50
	private Timer timer; //Field offset: 0x58
	private TimerCallback callback; //Field offset: 0x60
	private object cookie; //Field offset: 0x68

	[Category("Behavior")]
	[TimersDescription("Occurs when the Interval has elapsed.")]
	public event ElapsedEventHandler Elapsed
	{
		 add { } //Length: 159
		 remove { } //Length: 159
	}

	[Category("Behavior")]
	[DefaultValue(True)]
	[TimersDescription("Indicates whether the timer will be restarted when it is enabled.")]
	public bool AutoReset
	{
		 set { } //Length: 122
	}

	[Category("Behavior")]
	[DefaultValue(False)]
	[TimersDescription("Indicates whether the timer is enabled to fire events at a defined interval.")]
	public bool Enabled
	{
		 set { } //Length: 539
	}

	public virtual ISite Site
	{
		 get { } //Length: 5
	}

	[Browsable(False)]
	[DefaultValue(null)]
	[TimersDescription("The object used to marshal the event handler calls issued when an interval has elapsed.")]
	public ISynchronizeInvoke SynchronizingObject
	{
		 get { } //Length: 481
	}

	public Timer() { }

	public Timer(double interval) { }

	public void add_Elapsed(ElapsedEventHandler value) { }

	private static int CalculateRoundedInterval(double interval, bool argumentCheck = false) { }

	public void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual ISite get_Site() { }

	public ISynchronizeInvoke get_SynchronizingObject() { }

	private void MyTimerCallback(object state) { }

	public void remove_Elapsed(ElapsedEventHandler value) { }

	public void set_AutoReset(bool value) { }

	public void set_Enabled(bool value) { }

	public void Start() { }

	private void UpdateTimer() { }

}

