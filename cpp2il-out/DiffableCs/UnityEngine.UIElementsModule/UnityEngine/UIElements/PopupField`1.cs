namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class PopupField : BasePopupField<T, T>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public T item; //Field offset: 0x0
		public PopupField<T> <>4__this; //Field offset: 0x0

		public <>c__DisplayClass26_0() { }

		internal void <AddMenuItems>b__0() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	private int m_Index; //Field offset: 0x0

	public int index
	{
		 set { } //Length: 147
	}

	public virtual T value
	{
		 get { } //Length: 38
		 set { } //Length: 110
	}

	private static PopupField`1() { }

	public PopupField`1(string label = null) { }

	internal virtual void AddMenuItems(IGenericMenu menu) { }

	private void ChangeValueFromMenu(T menuItem) { }

	public virtual T get_value() { }

	internal virtual string GetListItemToDisplay(T value) { }

	internal virtual string GetValueToDisplay() { }

	public void set_index(int value) { }

	public virtual void set_value(T value) { }

	public virtual void SetValueWithoutNotify(T newValue) { }

}

