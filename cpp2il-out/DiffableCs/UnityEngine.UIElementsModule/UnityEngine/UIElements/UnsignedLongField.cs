namespace UnityEngine.UIElements;

public class UnsignedLongField : TextValueField<UInt64>
{
	private class UnsignedLongInput : TextValueInput<UInt64>
	{

		protected virtual string allowedCharacters
		{
			 get { } //Length: 79
		}

		private UnsignedLongField parentUnsignedLongField
		{
			private get { } //Length: 113
		}

		internal UnsignedLongInput() { }

		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue) { }

		private ulong ClampToMinMaxULongValue(long niceDelta, ulong value) { }

		protected virtual string get_allowedCharacters() { }

		private UnsignedLongField get_parentUnsignedLongField() { }

		protected virtual ulong StringToValue(string str) { }

		protected virtual string ValueToString(ulong v) { }

	}

	internal class UxmlFactory : UxmlFactory<UnsignedLongField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : TextValueFieldTraits<UInt64, UxmlUnsignedLongAttributeDescription>
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private UnsignedLongInput unsignedLongInput
	{
		private get { } //Length: 122
	}

	private static UnsignedLongField() { }

	public UnsignedLongField() { }

	public UnsignedLongField(string label, int maxLength = 1000) { }

	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue) { }

	internal virtual bool CanTryParse(string textString) { }

	private UnsignedLongInput get_unsignedLongInput() { }

	protected virtual ulong StringToValue(string str) { }

	protected virtual string ValueToString(ulong v) { }

}

