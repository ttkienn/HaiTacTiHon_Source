namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class LongField : TextValueField<Int64>
{
	private class LongInput : TextValueInput<Int64>
	{

		protected virtual string allowedCharacters
		{
			 get { } //Length: 79
		}

		private LongField parentLongField
		{
			private get { } //Length: 113
		}

		internal LongInput() { }

		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue) { }

		private long ClampMinMaxLongValue(long niceDelta, long value) { }

		protected virtual string get_allowedCharacters() { }

		private LongField get_parentLongField() { }

		protected virtual long StringToValue(string str) { }

		protected virtual string ValueToString(long v) { }

	}

	internal class UxmlFactory : UxmlFactory<LongField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : TextValueFieldTraits<Int64, UxmlLongAttributeDescription>
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private LongInput longInput
	{
		private get { } //Length: 122
	}

	private static LongField() { }

	public LongField() { }

	public LongField(string label, int maxLength = 1000) { }

	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue) { }

	internal virtual bool CanTryParse(string textString) { }

	private LongInput get_longInput() { }

	protected virtual long StringToValue(string str) { }

	protected virtual string ValueToString(long v) { }

}

