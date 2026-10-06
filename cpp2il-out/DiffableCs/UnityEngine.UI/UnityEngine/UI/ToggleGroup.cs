namespace UnityEngine.UI;

[AddComponentMenu("UI/Toggle Group", 31)]
[DisallowMultipleComponent]
public class ToggleGroup : UIBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Toggle> <>9__13_0; //Field offset: 0x8
		public static Func<Toggle, Boolean> <>9__14_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <ActiveToggles>b__14_0(Toggle x) { }

		internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	}

	[SerializeField]
	private bool m_AllowSwitchOff; //Field offset: 0x20
	protected List<Toggle> m_Toggles; //Field offset: 0x28

	public bool allowSwitchOff
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	protected ToggleGroup() { }

	public IEnumerable<Toggle> ActiveToggles() { }

	public bool AnyTogglesOn() { }

	public void EnsureValidState() { }

	public bool get_allowSwitchOff() { }

	public Toggle GetFirstActiveToggle() { }

	public void NotifyToggleOn(Toggle toggle, bool sendCallback = true) { }

	protected virtual void OnEnable() { }

	public void RegisterToggle(Toggle toggle) { }

	public void set_allowSwitchOff(bool value) { }

	public void SetAllTogglesOff(bool sendCallback = true) { }

	protected virtual void Start() { }

	public void UnregisterToggle(Toggle toggle) { }

	private void ValidateToggleIsInGroup(Toggle toggle) { }

}

