namespace UnityEngine.UIElements.Experimental;

public sealed class ValueAnimation : IValueAnimationUpdate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ValueAnimation<T> <.cctor>b__67_0() { }

	}

	private static ObjectPool<ValueAnimation`1<T>> sObjectPool; //Field offset: 0x0
	private long m_StartTimeMs; //Field offset: 0x0
	private int m_DurationMs; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Single, Single> <easingCurve>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isRunning>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <onAnimationCompleted>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <autoRecycle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <recycled>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <owner>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<VisualElement, T> <valueUpdated>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<VisualElement, T> <initialValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<T, T, Single, T> <interpolator>k__BackingField; //Field offset: 0x0
	private T _from; //Field offset: 0x0
	private bool fromValueSet; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private T <to>k__BackingField; //Field offset: 0x0

	public bool autoRecycle
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override int durationMs
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public Func<Single, Single> easingCurve
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public T from
	{
		 get { } //Length: 83
		 set { } //Length: 19
	}

	public Func<VisualElement, T> initialValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public Func<T, T, Single, T> interpolator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public private override bool isRunning
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Action onAnimationCompleted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	private VisualElement owner
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	private bool recycled
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public T to
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Action<VisualElement, T> valueUpdated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	private static ValueAnimation`1() { }

	public ValueAnimation`1() { }

	private void CheckNotRecycled() { }

	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, Single, T> interpolator) { }

	[CompilerGenerated]
	public bool get_autoRecycle() { }

	public override int get_durationMs() { }

	[CompilerGenerated]
	public Func<Single, Single> get_easingCurve() { }

	public T get_from() { }

	[CompilerGenerated]
	public Func<VisualElement, T> get_initialValue() { }

	[CompilerGenerated]
	public Func<T, T, Single, T> get_interpolator() { }

	[CompilerGenerated]
	public override bool get_isRunning() { }

	[CompilerGenerated]
	public Action get_onAnimationCompleted() { }

	[CompilerGenerated]
	private VisualElement get_owner() { }

	[CompilerGenerated]
	private bool get_recycled() { }

	[CompilerGenerated]
	public T get_to() { }

	[CompilerGenerated]
	public Action<VisualElement, T> get_valueUpdated() { }

	public ValueAnimation<T> KeepAlive() { }

	public override void Recycle() { }

	private void Register() { }

	[CompilerGenerated]
	public void set_autoRecycle(bool value) { }

	public override void set_durationMs(int value) { }

	[CompilerGenerated]
	public void set_easingCurve(Func<Single, Single> value) { }

	public void set_from(T value) { }

	[CompilerGenerated]
	public void set_initialValue(Func<VisualElement, T> value) { }

	[CompilerGenerated]
	public void set_interpolator(Func<T, T, Single, T> value) { }

	[CompilerGenerated]
	private void set_isRunning(bool value) { }

	[CompilerGenerated]
	public void set_onAnimationCompleted(Action value) { }

	[CompilerGenerated]
	private void set_owner(VisualElement value) { }

	[CompilerGenerated]
	private void set_recycled(bool value) { }

	[CompilerGenerated]
	public void set_to(T value) { }

	[CompilerGenerated]
	public void set_valueUpdated(Action<VisualElement, T> value) { }

	private void SetDefaultValues() { }

	internal void SetOwner(VisualElement e) { }

	public override void Start() { }

	public override void Stop() { }

	private override void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs) { }

	private void Unregister() { }

}

