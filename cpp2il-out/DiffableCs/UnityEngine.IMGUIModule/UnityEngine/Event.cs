namespace UnityEngine;

[NativeHeader("Modules/IMGUI/Event.bindings.h")]
[StaticAccessor("GUIEvent", StaticAccessorType::DoubleColon (2))]
public sealed class Event
{
	private static Event s_Current; //Field offset: 0x0
	private static Event s_MasterEvent; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x10

	public bool alt
	{
		 get { } //Length: 56
	}

	[NativeProperty("button", False, TargetType::Field (1))]
	public int button
	{
		 get { } //Length: 51
	}

	[NativeProperty("character", False, TargetType::Field (1))]
	public char character
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("clickCount", False, TargetType::Field (1))]
	public int clickCount
	{
		 get { } //Length: 51
	}

	public bool command
	{
		 get { } //Length: 56
	}

	public string commandName
	{
		[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
		 get { } //Length: 51
		[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
		 set { } //Length: 66
	}

	public bool control
	{
		 get { } //Length: 56
	}

	public static Event current
	{
		 get { } //Length: 54
		 set { } //Length: 165
	}

	[NativeProperty("delta", False, TargetType::Field (1))]
	public Vector2 delta
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	[NativeProperty("displayIndex", False, TargetType::Field (1))]
	public int displayIndex
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	internal bool isDirectManipulationDevice
	{
		internal get { } //Length: 109
	}

	public bool isKey
	{
		 get { } //Length: 75
	}

	public bool isMouse
	{
		 get { } //Length: 85
	}

	[NativeProperty("keycode", False, TargetType::Field (1))]
	public KeyCode keyCode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty("modifiers", False, TargetType::Field (1))]
	public EventModifiers modifiers
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty("mousePosition", False, TargetType::Field (1))]
	public Vector2 mousePosition
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	[NativeProperty("penStatus", False, TargetType::Field (1))]
	public PenStatus penStatus
	{
		 get { } //Length: 51
	}

	[NativeProperty("pointerType", False, TargetType::Field (1))]
	public PointerType pointerType
	{
		 get { } //Length: 51
	}

	[NativeProperty("pressure", False, TargetType::Field (1))]
	public float pressure
	{
		 get { } //Length: 51
	}

	[NativeProperty("type", False, TargetType::Field (1))]
	public EventType rawType
	{
		 get { } //Length: 51
	}

	public bool shift
	{
		 get { } //Length: 56
	}

	[NativeProperty("tilt", False, TargetType::Field (1))]
	public Vector2 tilt
	{
		 get { } //Length: 68
	}

	[NativeProperty("twist", False, TargetType::Field (1))]
	public float twist
	{
		 get { } //Length: 51
	}

	public EventType type
	{
		[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
		 get { } //Length: 51
		[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
		 set { } //Length: 64
	}

	public Event() { }

	public Event(int displayIndex) { }

	internal void CopyFrom(Event e) { }

	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"}])]
	internal void CopyFromPtr(IntPtr ptr) { }

	public virtual bool Equals(object obj) { }

	protected virtual void Finalize() { }

	public bool get_alt() { }

	public int get_button() { }

	public char get_character() { }

	public int get_clickCount() { }

	public bool get_command() { }

	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	public string get_commandName() { }

	public bool get_control() { }

	public static Event get_current() { }

	public Vector2 get_delta() { }

	private void get_delta_Injected(out Vector2 ret) { }

	public int get_displayIndex() { }

	internal bool get_isDirectManipulationDevice() { }

	public bool get_isKey() { }

	public bool get_isMouse() { }

	public KeyCode get_keyCode() { }

	public EventModifiers get_modifiers() { }

	public Vector2 get_mousePosition() { }

	private void get_mousePosition_Injected(out Vector2 ret) { }

	public PenStatus get_penStatus() { }

	public PointerType get_pointerType() { }

	public float get_pressure() { }

	public EventType get_rawType() { }

	public bool get_shift() { }

	public Vector2 get_tilt() { }

	private void get_tilt_Injected(out Vector2 ret) { }

	public float get_twist() { }

	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	public EventType get_type() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"}])]
	internal static int GetDoubleClickTime() { }

	public virtual int GetHashCode() { }

	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = True)]
	public EventType GetTypeForControl(int controlID) { }

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[RequiredByNativeCode]
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[NativeMethod("Use")]
	private void Internal_Use() { }

	public static Event KeyboardEvent(string key) { }

	public static bool PopEvent(Event outEvent) { }

	public void set_character(char value) { }

	[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
	public void set_commandName(string value) { }

	public static void set_current(Event value) { }

	public void set_delta(Vector2 value) { }

	private void set_delta_Injected(ref Vector2 value) { }

	public void set_displayIndex(int value) { }

	public void set_keyCode(KeyCode value) { }

	public void set_modifiers(EventModifiers value) { }

	public void set_mousePosition(Vector2 value) { }

	private void set_mousePosition_Injected(ref Vector2 value) { }

	[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
	public void set_type(EventType value) { }

	public virtual string ToString() { }

	public void Use() { }

}

