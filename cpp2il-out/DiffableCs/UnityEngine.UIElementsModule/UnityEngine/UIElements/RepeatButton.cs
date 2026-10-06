namespace UnityEngine.UIElements;

public class RepeatButton : TextElement
{
	internal class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : UxmlTraits
	{
		private UxmlLongAttributeDescription m_Delay; //Field offset: 0x98
		private UxmlLongAttributeDescription m_Interval; //Field offset: 0xA0

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	private Clickable m_Clickable; //Field offset: 0x4A0
	private bool m_AcceptClicksIfDisabled; //Field offset: 0x4A8

	internal bool acceptClicksIfDisabled
	{
		internal set { } //Length: 40
	}

	private static RepeatButton() { }

	public RepeatButton() { }

	public RepeatButton(Action clickEvent, long delay, long interval) { }

	internal void AddAction(Action clickEvent) { }

	internal void set_acceptClicksIfDisabled(bool value) { }

	public void SetAction(Action clickEvent, long delay, long interval) { }

}

