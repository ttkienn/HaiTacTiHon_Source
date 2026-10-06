namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BaseCompositeField : BaseField<TValueType>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public FieldDescription<TValueType, TField, TFieldValue> desc; //Field offset: 0x0
		public TField field; //Field offset: 0x0
		public BaseCompositeField<TValueType, TField, TFieldValue> <>4__this; //Field offset: 0x0

		public <>c__DisplayClass24_0() { }

		internal TFieldValue <.ctor>b__0(TFieldValue newValue) { }

		internal void <.ctor>b__1(ChangeEvent<TFieldValue> e) { }

	}

	public struct FieldDescription
	{
		internal sealed class WriteDelegate : MulticastDelegate
		{

			public WriteDelegate(object object, IntPtr method) { }

			public override void Invoke(ref TValueType val, TFieldValue fieldValue) { }

		}

		internal readonly string name; //Field offset: 0x0
		internal readonly string ussName; //Field offset: 0x0
		internal readonly Func<TValueType, TFieldValue> read; //Field offset: 0x0
		internal readonly WriteDelegate<TValueType, TField, TFieldValue> write; //Field offset: 0x0

		public FieldDescription(string name, string ussName, Func<TValueType, TFieldValue> read, WriteDelegate<TValueType, TField, TFieldValue> write) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x0
	public static readonly string inputUssClassName; //Field offset: 0x0
	public static readonly string spacerUssClassName; //Field offset: 0x0
	public static readonly string multilineVariantUssClassName; //Field offset: 0x0
	public static readonly string fieldGroupUssClassName; //Field offset: 0x0
	public static readonly string fieldUssClassName; //Field offset: 0x0
	public static readonly string firstFieldVariantUssClassName; //Field offset: 0x0
	public static readonly string twoLinesVariantUssClassName; //Field offset: 0x0
	private List<TField> m_Fields; //Field offset: 0x0
	private bool m_ShouldUpdateDisplay; //Field offset: 0x0
	private bool m_ForceUpdateDisplay; //Field offset: 0x0
	private int m_PropertyIndex; //Field offset: 0x0

	private static BaseCompositeField`3() { }

	protected BaseCompositeField`3(string label, int fieldsByLine) { }

	internal abstract FieldDescription<TValueType, TField, TFieldValue>[] DescribeFields() { }

	private VisualElement GetSpacer() { }

	internal virtual void OnViewDataReady() { }

	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	private void UpdateDisplay() { }

	protected virtual void UpdateMixedValueContent() { }

}

