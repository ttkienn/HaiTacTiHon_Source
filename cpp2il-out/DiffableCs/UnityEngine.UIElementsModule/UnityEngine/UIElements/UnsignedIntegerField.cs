namespace UnityEngine.UIElements;

public class UnsignedIntegerField : TextValueField<UInt32>
{
	private class UnsignedIntegerInput : TextValueInput<UInt32>
	{

		protected virtual string allowedCharacters
		{
			 get { } //Length: 79
		}

		private UnsignedIntegerField parentUnsignedIntegerField
		{
			private get { } //Length: 113
		}

		internal UnsignedIntegerInput() { }

		public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

		protected virtual string get_allowedCharacters() { }

		private UnsignedIntegerField get_parentUnsignedIntegerField() { }

		protected virtual uint StringToValue(string str) { }

		protected virtual string ValueToString(uint v) { }

	}

	internal class UxmlFactory : UxmlFactory<UnsignedIntegerField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	internal class UxmlTraits : TextValueFieldTraits<UInt32, UxmlUnsignedIntAttributeDescription>
	{

		public UxmlTraits() { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x8
	public static readonly string inputUssClassName; //Field offset: 0x10

	private UnsignedIntegerInput integerInput
	{
		private get { } //Length: 122
	}

	private static UnsignedIntegerField() { }

	public UnsignedIntegerField() { }

	public UnsignedIntegerField(string label, int maxLength = 1000) { }

	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue) { }

	internal virtual bool CanTryParse(string textString) { }

	private UnsignedIntegerInput get_integerInput() { }

	protected virtual uint StringToValue(string str) { }

	protected virtual string ValueToString(uint v) { }

}

