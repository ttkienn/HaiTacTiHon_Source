namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
public abstract class PointerEventBase : EventBase<T>, IPointerEvent, IPointerEventInternal
{
	private bool m_AltitudeNeedsConversion; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <radius>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PenStatus <penStatus>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <twist>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <tangentialPressure>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <pressure>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <clickCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <deltaTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <deltaPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <localPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <pressedButtons>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isPrimary>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <pointerType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <pointerId>k__BackingField; //Field offset: 0x0
	private Vector2 m_Tilt; //Field offset: 0x0
	private bool m_TiltNeeded; //Field offset: 0x0
	private float m_AzimuthAngle; //Field offset: 0x0
	private float m_AltitudeAngle; //Field offset: 0x0
	private bool m_AzimuthNeedsConversion; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <position>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField; //Field offset: 0x0

	public override bool actionKey
	{
		 get { } //Length: 138
	}

	public override float altitudeAngle
	{
		 get { } //Length: 140
		 set { } //Length: 16
	}

	public override bool altKey
	{
		 get { } //Length: 13
	}

	public override float azimuthAngle
	{
		 get { } //Length: 279
		 set { } //Length: 16
	}

	public override int button
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int clickCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool commandKey
	{
		 get { } //Length: 13
	}

	public override bool ctrlKey
	{
		 get { } //Length: 13
	}

	public internal virtual IEventHandler currentTarget
	{
		 get { } //Length: 25
		internal set { } //Length: 284
	}

	public override Vector3 deltaPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public override float deltaTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override bool isPrimary
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Vector3 localPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public override EventModifiers modifiers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override PenStatus penStatus
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int pointerId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override string pointerType
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public override Vector3 position
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public override int pressedButtons
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override float pressure
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override Vector2 radius
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override Vector2 radiusVariance
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override bool shiftKey
	{
		 get { } //Length: 13
	}

	public override float tangentialPressure
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override Vector2 tilt
	{
		 get { } //Length: 411
		 set { } //Length: 15
	}

	public override float twist
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	private override bool UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.IPointerEventInternal.triggeredByOS
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected PointerEventBase`1() { }

	private static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	public override bool get_actionKey() { }

	public override float get_altitudeAngle() { }

	public override bool get_altKey() { }

	public override float get_azimuthAngle() { }

	[CompilerGenerated]
	public override int get_button() { }

	[CompilerGenerated]
	public override int get_clickCount() { }

	public override bool get_commandKey() { }

	public override bool get_ctrlKey() { }

	public virtual IEventHandler get_currentTarget() { }

	[CompilerGenerated]
	public override Vector3 get_deltaPosition() { }

	[CompilerGenerated]
	public override float get_deltaTime() { }

	[CompilerGenerated]
	public override bool get_isPrimary() { }

	[CompilerGenerated]
	public override Vector3 get_localPosition() { }

	[CompilerGenerated]
	public override EventModifiers get_modifiers() { }

	[CompilerGenerated]
	public override PenStatus get_penStatus() { }

	[CompilerGenerated]
	public override int get_pointerId() { }

	[CompilerGenerated]
	public override string get_pointerType() { }

	[CompilerGenerated]
	public override Vector3 get_position() { }

	[CompilerGenerated]
	public override int get_pressedButtons() { }

	[CompilerGenerated]
	public override float get_pressure() { }

	[CompilerGenerated]
	public override Vector2 get_radius() { }

	[CompilerGenerated]
	public override Vector2 get_radiusVariance() { }

	public override bool get_shiftKey() { }

	[CompilerGenerated]
	public override float get_tangentialPressure() { }

	public override Vector2 get_tilt() { }

	[CompilerGenerated]
	public override float get_twist() { }

	internal static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers) { }

	public static T GetPooled(IPointerEvent triggerEvent) { }

	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	public static T GetPooled(PenData pen, EventModifiers modifiers = 0) { }

	public static T GetPooled(Touch touch, EventModifiers modifiers = 0) { }

	public static T GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private static bool IsMouse(Event systemEvent) { }

	private static bool IsTouch(Event systemEvent) { }

	private void LocalInit() { }

	protected private virtual void PostDispatch(IPanel panel) { }

	protected private virtual void PreDispatch(IPanel panel) { }

	protected void set_altitudeAngle(float value) { }

	protected void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	protected void set_button(int value) { }

	[CompilerGenerated]
	protected void set_clickCount(int value) { }

	internal virtual void set_currentTarget(IEventHandler value) { }

	[CompilerGenerated]
	protected void set_deltaPosition(Vector3 value) { }

	[CompilerGenerated]
	protected void set_deltaTime(float value) { }

	[CompilerGenerated]
	protected void set_isPrimary(bool value) { }

	[CompilerGenerated]
	protected void set_localPosition(Vector3 value) { }

	[CompilerGenerated]
	protected void set_modifiers(EventModifiers value) { }

	[CompilerGenerated]
	protected void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	protected void set_pointerId(int value) { }

	[CompilerGenerated]
	protected void set_pointerType(string value) { }

	[CompilerGenerated]
	protected void set_position(Vector3 value) { }

	[CompilerGenerated]
	protected void set_pressedButtons(int value) { }

	[CompilerGenerated]
	protected void set_pressure(float value) { }

	[CompilerGenerated]
	protected void set_radius(Vector2 value) { }

	[CompilerGenerated]
	protected void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	protected void set_tangentialPressure(float value) { }

	protected void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	protected void set_twist(float value) { }

	private static float TiltToAltitude(Vector2 tilt) { }

	private static float TiltToAzimuth(Vector2 tilt) { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value) { }

}

